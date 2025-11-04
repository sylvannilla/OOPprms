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
            loginButton = new Button();
            button1 = new Button();
            errorLabel = new Label();
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
            // loginButton
            // 
            loginButton.Location = new Point(182, 325);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(167, 366);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 3;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(errorLabel);
            Controls.Add(button1);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button button1;
        private Label errorLabel;
    }
}