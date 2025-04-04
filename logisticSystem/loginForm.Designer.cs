namespace logisticSystem
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            passwordLoginTxtBx = new TextBox();
            loginBtn = new Button();
            registerBtn = new Button();
            enterEmailLabel = new Label();
            enterPasswordLabel = new Label();
            usernameLoginTxtBx = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // passwordLoginTxtBx
            // 
            passwordLoginTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            passwordLoginTxtBx.BorderStyle = BorderStyle.FixedSingle;
            passwordLoginTxtBx.Cursor = Cursors.IBeam;
            passwordLoginTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLoginTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            passwordLoginTxtBx.Location = new Point(124, 75);
            passwordLoginTxtBx.Multiline = true;
            passwordLoginTxtBx.Name = "passwordLoginTxtBx";
            passwordLoginTxtBx.PasswordChar = '*';
            passwordLoginTxtBx.Size = new Size(228, 25);
            passwordLoginTxtBx.TabIndex = 3;
            passwordLoginTxtBx.TextChanged += passwordLoginTxtBx_TextChanged;
            passwordLoginTxtBx.Validating += passwordLoginTxtBx_Validating;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(39, 84, 138);
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            loginBtn.ForeColor = Color.FromArgb(245, 238, 220);
            loginBtn.Location = new Point(311, 146);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "&Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(39, 84, 138);
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            registerBtn.ForeColor = Color.FromArgb(245, 238, 220);
            registerBtn.Location = new Point(311, 181);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 29);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "&Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // enterEmailLabel
            // 
            enterEmailLabel.AutoSize = true;
            enterEmailLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            enterEmailLabel.ForeColor = Color.FromArgb(24, 59, 78);
            enterEmailLabel.Location = new Point(40, 49);
            enterEmailLabel.Name = "enterEmailLabel";
            enterEmailLabel.Size = new Size(82, 16);
            enterEmailLabel.TabIndex = 5;
            enterEmailLabel.Text = "Username:";
            enterEmailLabel.Click += enterEmailLabel_Click;
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize = true;
            enterPasswordLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            enterPasswordLabel.ForeColor = Color.FromArgb(24, 59, 78);
            enterPasswordLabel.Location = new Point(43, 79);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(79, 16);
            enterPasswordLabel.TabIndex = 6;
            enterPasswordLabel.Text = "Password:";
            enterPasswordLabel.Click += enterPasswordLabel_Click;
            // 
            // usernameLoginTxtBx
            // 
            usernameLoginTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            usernameLoginTxtBx.BorderStyle = BorderStyle.FixedSingle;
            usernameLoginTxtBx.Cursor = Cursors.IBeam;
            usernameLoginTxtBx.Font = new Font("Microsoft Sans Serif", 10F);
            usernameLoginTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            usernameLoginTxtBx.Location = new Point(124, 44);
            usernameLoginTxtBx.Multiline = true;
            usernameLoginTxtBx.Name = "usernameLoginTxtBx";
            usernameLoginTxtBx.Size = new Size(228, 25);
            usernameLoginTxtBx.TabIndex = 1;
            usernameLoginTxtBx.TextChanged += usernameLoginTxtBx_TextChanged;
            usernameLoginTxtBx.Validating += usernameLoginTxtBx_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(422, 253);
            Controls.Add(usernameLoginTxtBx);
            Controls.Add(enterPasswordLabel);
            Controls.Add(enterEmailLabel);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordLoginTxtBx);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordLoginTxtBx;
        private Button loginBtn;
        private Button registerBtn;
        private Label enterEmailLabel;
        private Label enterPasswordLabel;
        private TextBox usernameLoginTxtBx;
        private ErrorProvider errorProvider;
    }
}
