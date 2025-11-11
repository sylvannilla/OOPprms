using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        private readonly BookingManager bookingManager;
        private readonly System.Windows.Forms.Timer timerDateTime;

        public Form1()
        {
            InitializeComponent();

            // Timer for submission timestamp
            timerDateTime = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timerDateTime.Tick += TimerDateTime_Tick;

            bookingManager = new BookingManager();
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
            appointmentTimePicker.CustomFormat = "hh:mm tt";
            appointmentTimePicker.ShowUpDown = true;
            appointmentTimePicker.Value = DateTime.Today;
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // ----------------- Validation -----------------

            // Gender
            if (genderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Medication RadioButtons
            string medicationStatus = GetMedicationStatus();
            if (string.IsNullOrEmpty(medicationStatus))
            {
                MessageBox.Show("Please indicate if the patient is currently taking any medication.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Age: only digits
            if (!int.TryParse(ageTextBox.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age using digits only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ageTextBox.Focus();
                return;
            }

            // Contact Number: digits only, max 11 digits
            string phone = phoneNumberTextBox.Text.Trim();
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Contact number can only contain digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNumberTextBox.Focus();
                return;
            }
            if (phone.Length > 11)
            {
                MessageBox.Show("Contact number cannot be more than 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNumberTextBox.Focus();
                return;
            }

            // ----------------- Continue Submission -----------------
            DateTime appointmentDateTime = appointmentDatePicker.Value.Date + appointmentTimePicker.Value.TimeOfDay;
            DateTime submissionDateTime = DateTime.Now;

            string fullAddress = AddressFormatter.Format(
                streetTextBox.Text,
                cityTextBox.Text,
                stateProvinceTextBox.Text,
                postalZipTextBox.Text
            );

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
                appointmentDateTime.ToString("MM/dd/yyyy hh:mm tt"),
                additionalNotesTextBox.Text
            );

            confirmForm.ShowDialog();

            if (!confirmForm.Confirmed)
                return;

            bookingManager.InsertBooking(
                appointmentDateTime,
                submissionDateTime,
                nameTextBox.Text,
                genderComboBox.Text,
                ageTextBox.Text,
                dateOfBirthTextBox.Text,
                phoneNumberTextBox.Text,
                emailTextBox.Text,
                fullAddress,
                medicationStatus,
                additionalNotesTextBox.Text
            );

            MessageBox.Show("Your appointment has been successfully booked. Please wait for a confirmation via text message or email.");
            ClearForm();
        }

        private string GetMedicationStatus()
        {
            if (yesRadioButton.Checked) return "Yes";
            if (noRadioButton.Checked) return "No";
            return string.Empty;
        }

        private void ClearForm()
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
            additionalNotesTextBox.Clear();

            yesRadioButton.Checked = false;
            noRadioButton.Checked = false;
            nameTextBox.Focus();
        }

        private void dateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {
            dateOfBirthTextBox.Text = DateFormatter.FormatAsYYYYMMDD(dateOfBirthTextBox.Text, dateOfBirthTextBox.SelectionStart, out int cursorPos);
            dateOfBirthTextBox.SelectionStart = cursorPos;
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // ==================== Helper Classes ====================

    public static class AddressFormatter
    {
        public static string Format(string street, string city, string state, string postal)
        {
            return $"{street}, \n{city}, \n{state}, {postal}";
        }
    }

    public static class DateFormatter
    {
        public static string FormatAsYYYYMMDD(string input, int currentCursor, out int newCursor)
        {
            string digits = System.Text.RegularExpressions.Regex.Replace(input, @"\D", "");
            if (digits.Length > 8) digits = digits.Substring(0, 8);

            string formatted = digits;
            if (digits.Length > 4 && digits.Length <= 6)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
            else if (digits.Length > 6)
                formatted = digits.Substring(0, 4) + "-" + digits.Substring(4, 2) + "-" + digits.Substring(6);

            // Fix cursor position
            int dashBefore = input.Take(currentCursor).Count(c => c == '-');
            int dashAfter = formatted.Take(currentCursor).Count(c => c == '-');
            newCursor = currentCursor + (dashAfter - dashBefore);

            return formatted;
        }
    }

    public class BookingManager
    {
        private readonly string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                                   "Port=19631;" +
                                                   "Database=defaultdb;" +
                                                   "User ID=avnadmin;" +
                                                   "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                                   "SslMode=Required;";

        public void InsertBooking(DateTime appointmentDateTime, DateTime submissionDateTime, string patientName,
                                  string gender, string age, string dateOfBirth, string phoneNumber, string email,
                                  string address, string currentMedication, string additionalNotes)
        {
            using var con = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(@" INSERT INTO oop_project.booking 
                                            (appointment_datetime, submission_datetime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication, additional_notes, status)
                                            VALUES 
                                            (@appointment_datetime, @submission_datetime, @patientname, @gender, @age, @dateofbirth, @phonenumber, @email, @address, @current_medication, @additional_notes, @status)", con);

            cmd.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
            cmd.Parameters.AddWithValue("@submission_datetime", submissionDateTime);
            cmd.Parameters.AddWithValue("@patientname", patientName);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@phonenumber", phoneNumber);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@current_medication", currentMedication);
            cmd.Parameters.AddWithValue("@additional_notes", additionalNotes);
            cmd.Parameters.AddWithValue("@status", "Pending"); // NEW


            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
