using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        string strConn = "server=localhost;user id=root;password=;database=db_oop";
        private System.Windows.Forms.Timer timerDateTime; // Timer declaration

        public Form1()
        {
            InitializeComponent();

            // Initialize timer
            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000; // 1 second
            timerDateTime.Tick += timerDateTime_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.Items.Add("Other");

            dateTextBox.ReadOnly = true;
            dateTextBox.BackColor = Color.White;

            dateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

            timerDateTime.Start();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new MySqlConnection(strConn))
                using (var cmd = new MySqlCommand(@"INSERT INTO booking 
                        (dateandtime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication)
                        VALUES (@dateandtime, @patientname, @gender, @age, @dateofbirth, @phonenumber, @email, @address, @current_medication)", con))
                {
                    string fullAddress = $"{streetTextBox.Text}, {cityTextBox.Text}, {stateProvinceTextBox.Text}, {postalZipTextBox.Text}";

                    if (genderComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a gender before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string medicationStatus = "";
                    if (yesCheckBox.Checked)
                        medicationStatus = "Yes";
                    else if (noCheckBox.Checked)
                        medicationStatus = "No";
                    else
                    {
                        MessageBox.Show("Please indicate if the patient is currently taking any medication.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@dateandtime", DateTime.Now);
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

        // Make Yes/No checkboxes behave like radio buttons
        private void yesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yesCheckBox.Checked)
                noCheckBox.Checked = false;
        }

        private void noCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noCheckBox.Checked)
                yesCheckBox.Checked = false;
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
            yesCheckBox.Checked = false;
            noCheckBox.Checked = false;
            
            nameTextBox.Focus();
        }

        // ------- UI Event Handlers (empty but needed for designer) -------
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
    }
}
