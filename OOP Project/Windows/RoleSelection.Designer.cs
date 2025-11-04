namespace OOP_Project
{
    partial class RoleSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            patientButton = new Button();
            adminButton = new Button();
            SuspendLayout();
            // 
            // patientButton
            // 
            patientButton.Location = new Point(65, 100);
            patientButton.Name = "patientButton";
            patientButton.Size = new Size(75, 23);
            patientButton.TabIndex = 0;
            patientButton.Text = "Booking";
            patientButton.UseVisualStyleBackColor = true;
            patientButton.Click += patientButton_Click;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(247, 100);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 23);
            adminButton.TabIndex = 0;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // RoleSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 233);
            Controls.Add(adminButton);
            Controls.Add(patientButton);
            Name = "RoleSelection";
            Text = "RoleSelection";
            Load += RoleSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button patientButton;
        private Button adminButton;
    }
}