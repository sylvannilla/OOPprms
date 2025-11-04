using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class RoleSelection : Form
    {
        public RoleSelection()
        {
            InitializeComponent();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            Form1 booking = new Form1();
            booking.Show();
            this.Hide();
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void RoleSelection_Load(object sender, EventArgs e)
        {

        }

        
    }
}
