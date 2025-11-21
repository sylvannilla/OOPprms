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
            timerDateTime = new System.Windows.Forms.Timer { Interval = 1000 };
            timerDateTime.Tick += TimerDateTime_Tick;

            bookingManager = new BookingManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.AddRange(new string[] { "Male", "Female", "Prefer to not say" });

            dateTextBox.ReadOnly = true;
            dateTextBox.BackColor = Color.White;
            dateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            timerDateTime.Start();

            appointmentDatePicker.Format = DateTimePickerFormat.Custom;
            appointmentDatePicker.CustomFormat = "MMMM dd, yyyy";
            appointmentDatePicker.MinDate = DateTime.Today;
            appointmentDatePicker.MaxDate = DateTime.Today.AddMonths(6);

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
            // --- Validation ---

            if (genderComboBox.SelectedIndex == -1)
            {
                bookingManager.ShowValidationMessage("Please select a gender.");
                return;
            }

            string medicationStatus =
                bookingManager.GetMedicationStatus(yesRadioButton, noRadioButton);

            if (string.IsNullOrEmpty(medicationStatus))
            {
                bookingManager.ShowValidationMessage("Please indicate if the patient is currently taking any medication.");
                return;
            }

            if (!int.TryParse(ageTextBox.Text, out int age) || age <= 0)
            {
                bookingManager.ShowValidationMessage("Please enter a valid age using digits only.");
                ageTextBox.Focus();
                return;
            }

            string phone = phoneNumberTextBox.Text.Trim();
            if (!phone.All(char.IsDigit))
            {
                bookingManager.ShowValidationMessage("Contact number can only contain digits.");
                phoneNumberTextBox.Focus();
                return;
            }

            if (phone.Length > 11)
            {
                bookingManager.ShowValidationMessage("Contact number cannot be more than 11 digits.");
                phoneNumberTextBox.Focus();
                return;
            }

            // --- Prepare data ---
            DateTime appointmentDateTime = appointmentDatePicker.Value.Date + appointmentTimePicker.Value.TimeOfDay;
            DateTime submissionDateTime = DateTime.Now;

            string fullAddress = AddressFormatter.Format(
                streetTextBox.Text,
                cityTextBox.Text,
                stateProvinceTextBox.Text,
                postalZipTextBox.Text
            );

            // Open confirmation window
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
            dateOfBirthTextBox.Text = DateFormatter.FormatAsYYYYMMDD(
                dateOfBirthTextBox.Text,
                dateOfBirthTextBox.SelectionStart,
                out int cursorPos);

            dateOfBirthTextBox.SelectionStart = cursorPos;
        }
        private void dateTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
