namespace OOP_Project
{
    partial class Login
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            btnLogin = new Button();
            btnCreateAccount = new Button();
            errorLabel = new Label();
            btnBackLogin = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(141, 222);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(160, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(141, 267);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(160, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(182, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(167, 366);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(109, 23);
            btnCreateAccount.TabIndex = 3;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            errorLabel.Location = new Point(141, 293);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 3;
            // 
            // btnBackLogin
            // 
            btnBackLogin.Location = new Point(14, 16);
            btnBackLogin.Name = "btnBackLogin";
            btnBackLogin.Size = new Size(75, 23);
            btnBackLogin.TabIndex = 4;
            btnBackLogin.Text = "Back";
            btnBackLogin.UseVisualStyleBackColor = true;
            btnBackLogin.Click += btnBackLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(btnBackLogin);
            Controls.Add(errorLabel);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button btnLogin;
        private Button btnCreateAccount;
        private Label errorLabel;
        private Button btnBackLogin;
    }
}