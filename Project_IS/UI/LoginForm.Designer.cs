namespace Project_IS.UI
{
    partial class LoginForm
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
            Welcome = new Label();
            buttonLogin = new Button();
            UserLabel = new Label();
            PasswordLabel = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Location = new Point(360, 76);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(70, 15);
            Welcome.TabIndex = 0;
            Welcome.Text = "Please login";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(369, 298);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(346, 187);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(30, 15);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "User";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(319, 225);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(382, 184);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(100, 23);
            textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(382, 217);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(115, 149);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(buttonLogin);
            Controls.Add(Welcome);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private Button buttonLogin;
        private Label UserLabel;
        private Label PasswordLabel;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button button1;
    }
}