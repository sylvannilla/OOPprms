using System;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class FormConfirmBooking : Form
    {
        public bool Confirmed { get; private set; } = false;

        // Constructor receives all data from Form1
        public FormConfirmBooking(
            string patientName,
            string gender,
            string age,
            string dateOfBirth,
            string phoneNumber,
            string email,
            string address,
            string currentMedication,
            string submissionTime,
            string appointmentTime,
            string additionalNotes)
        {
            InitializeComponent();

            // Assign labels immediately
            lblPatientName.Text = patientName;
            lblGender.Text = gender;
            lblAge.Text = age;
            lblDateOfBirth.Text = dateOfBirth;
            lblPhone.Text = phoneNumber;
            lblEmail.Text = email;
            lblAddress.Text = address;
            lblMedication.Text = currentMedication;
            lblAppointmentTime.Text = appointmentTime;
            lblAdditionalNotes.Text = additionalNotes;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            this.Close();
        }

        private void FormConfirmBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
