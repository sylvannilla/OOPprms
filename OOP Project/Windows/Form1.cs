using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        string strConn = "server=localhost;user id=root;password=;database=db_oop";
        private System.Windows.Forms.Timer timerDateTime;

        public Form1()
        {
            InitializeComponent();

            // Timer for submission timestamp
            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timerDateTime_Tick;
        }

        private void timerDateTime_Tick(object? sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gender ComboBox
            genderComboBox.Items.AddRange(new string[] { "Male", "Female", "Prefer to not say" });

            dateTextBox.ReadOnly = true;
            dateTextBox.BackColor = Color.White;
            dateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            timerDateTime.Start();

            // Appointment Date Picker
            appointmentDatePicker.Format = DateTimePickerFormat.Custom;
            appointmentDatePicker.CustomFormat = "MMMM dd, yyyy";
            appointmentDatePicker.MinDate = DateTime.Today;
            appointmentDatePicker.MaxDate = DateTime.Today.AddMonths(6);

            // Appointment Time Picker
            appointmentTimePicker.Format = DateTimePickerFormat.Custom;
            appointmentTimePicker.CustomFormat = "hh:mm tt";  // 12-hour format with AM/PM
            appointmentTimePicker.ShowUpDown = true;         // Shows up/down arrows instead of dropdown
            appointmentTimePicker.Value = DateTime.Today;    // Sets default to 00:00 AM

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime appointmentDateTime = appointmentDatePicker.Value.Date + appointmentTimePicker.Value.TimeOfDay;
            DateTime submissionDateTime = DateTime.Now;

            // Validation
            if (genderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use RadioButtons instead of CheckBoxes
            string medicationStatus = "";
            if (yesRadioButton.Checked)
                medicationStatus = "Yes";
            else if (noRadioButton.Checked)
                medicationStatus = "No";

            if (string.IsNullOrEmpty(medicationStatus))
            {
                MessageBox.Show("Please indicate if the patient is currently taking any medication.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullAddress = $"{streetTextBox.Text}, {cityTextBox.Text}, {stateProvinceTextBox.Text}, {postalZipTextBox.Text}";

            // Pass all data to confirmation form
            FormConfirmBooking confirmForm = new FormConfirmBooking(
                nameTextBox.Text,
                genderComboBox.Text,
                ageTextBox.Text,
                dateOfBirthTextBox.Text,
                phoneNumberTextBox.Text,
                emailTextBox.Text,
                fullAddress,
                medicationStatus,
                submissionDateTime.ToString("MM/dd/yyyy hh:mm tt"),
                appointmentDateTime.ToString("MM/dd/yyyy hh:mm tt")
            );

            confirmForm.ShowDialog();

            if (!confirmForm.Confirmed)
            {
                MessageBox.Show("Submission cancelled.");
                return;
            }

            // Save to database
            try
            {
                using (var con = new MySqlConnection(strConn))
                using (var cmd = new MySqlCommand(@"INSERT INTO booking 
            (appointment_datetime, submission_datetime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication)
            VALUES (@appointment_datetime, @submission_datetime, @patientname, @gender, @age, @dateofbirth, @phonenumber, @email, @address, @current_medication)", con))
                {
                    cmd.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
                    cmd.Parameters.AddWithValue("@submission_datetime", submissionDateTime);
                    cmd.Parameters.AddWithValue("@patientname", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    cmd.Parameters.AddWithValue("@age", ageTextBox.Text);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirthTextBox.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", phoneNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@address", fullAddress);
                    cmd.Parameters.AddWithValue("@current_medication", medicationStatus);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Added Successfully!");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void clear()
        {
            nameTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            ageTextBox.Clear();
            dateOfBirthTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            streetTextBox.Clear();
            cityTextBox.Clear();
            stateProvinceTextBox.Clear();
            postalZipTextBox.Clear();

            nameTextBox.Focus();
        }
    }
}
