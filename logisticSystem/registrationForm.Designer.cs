namespace logisticSystem
{
    partial class registrationForm
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
            components = new System.ComponentModel.Container();
            firstNameRegTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lastNameRegTxtBx = new TextBox();
            label3 = new Label();
            phoneNumberRegTxtBx = new TextBox();
            label4 = new Label();
            userNameRegTxtBx = new TextBox();
            label5 = new Label();
            passwordRegTxtBx = new TextBox();
            label6 = new Label();
            confirmPasswordRegTxtBx = new TextBox();
            registerSbmtBtn = new Button();
            backToLoginBtn = new Button();
            label7 = new Label();
            regErrorProv = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)regErrorProv).BeginInit();
            SuspendLayout();
            // 
            // firstNameRegTxtBx
            // 
            firstNameRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            firstNameRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            firstNameRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            firstNameRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            firstNameRegTxtBx.Location = new Point(221, 71);
            firstNameRegTxtBx.Multiline = true;
            firstNameRegTxtBx.Name = "firstNameRegTxtBx";
            firstNameRegTxtBx.Size = new Size(173, 30);
            firstNameRegTxtBx.TabIndex = 0;
            firstNameRegTxtBx.TextChanged += textBox1_TextChanged;
            firstNameRegTxtBx.Validating += firstNameRegTxtBx_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 59, 78);
            label1.Location = new Point(136, 78);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 2;
            label1.Text = "First name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(24, 59, 78);
            label2.Location = new Point(137, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 4;
            label2.Text = "Last name:";
            // 
            // lastNameRegTxtBx
            // 
            lastNameRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            lastNameRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            lastNameRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            lastNameRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            lastNameRegTxtBx.Location = new Point(221, 107);
            lastNameRegTxtBx.Multiline = true;
            lastNameRegTxtBx.Name = "lastNameRegTxtBx";
            lastNameRegTxtBx.Size = new Size(173, 30);
            lastNameRegTxtBx.TabIndex = 3;
            lastNameRegTxtBx.Validating += lastNameRegTxtBx_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(24, 59, 78);
            label3.Location = new Point(106, 150);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 6;
            label3.Text = "Phone Number:";
            // 
            // phoneNumberRegTxtBx
            // 
            phoneNumberRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            phoneNumberRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            phoneNumberRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            phoneNumberRegTxtBx.Location = new Point(221, 143);
            phoneNumberRegTxtBx.Multiline = true;
            phoneNumberRegTxtBx.Name = "phoneNumberRegTxtBx";
            phoneNumberRegTxtBx.Size = new Size(173, 30);
            phoneNumberRegTxtBx.TabIndex = 5;
            phoneNumberRegTxtBx.KeyPress += phoneNumberRegTxtBx_KeyPress;
            phoneNumberRegTxtBx.Validating += phoneNumberRegTxtBx_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(24, 59, 78);
            label4.Location = new Point(137, 186);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 8;
            label4.Text = "Username:";
            // 
            // userNameRegTxtBx
            // 
            userNameRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            userNameRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            userNameRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            userNameRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            userNameRegTxtBx.Location = new Point(221, 179);
            userNameRegTxtBx.Multiline = true;
            userNameRegTxtBx.Name = "userNameRegTxtBx";
            userNameRegTxtBx.Size = new Size(173, 30);
            userNameRegTxtBx.TabIndex = 7;
            userNameRegTxtBx.Validating += userNameRegTxtBx_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(24, 59, 78);
            label5.Location = new Point(90, 222);
            label5.Name = "label5";
            label5.Size = new Size(129, 16);
            label5.TabIndex = 10;
            label5.Text = "Create Password:";
            // 
            // passwordRegTxtBx
            // 
            passwordRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            passwordRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            passwordRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            passwordRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            passwordRegTxtBx.Location = new Point(221, 215);
            passwordRegTxtBx.Multiline = true;
            passwordRegTxtBx.Name = "passwordRegTxtBx";
            passwordRegTxtBx.PasswordChar = '*';
            passwordRegTxtBx.Size = new Size(173, 30);
            passwordRegTxtBx.TabIndex = 9;
            passwordRegTxtBx.Validating += passwordRegTxtBx_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(24, 59, 78);
            label6.Location = new Point(84, 258);
            label6.Name = "label6";
            label6.Size = new Size(135, 16);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password:";
            // 
            // confirmPasswordRegTxtBx
            // 
            confirmPasswordRegTxtBx.BackColor = Color.FromArgb(245, 238, 220);
            confirmPasswordRegTxtBx.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordRegTxtBx.Font = new Font("Microsoft Sans Serif", 9.75F);
            confirmPasswordRegTxtBx.ForeColor = Color.FromArgb(24, 59, 78);
            confirmPasswordRegTxtBx.Location = new Point(221, 251);
            confirmPasswordRegTxtBx.Multiline = true;
            confirmPasswordRegTxtBx.Name = "confirmPasswordRegTxtBx";
            confirmPasswordRegTxtBx.PasswordChar = '*';
            confirmPasswordRegTxtBx.Size = new Size(173, 30);
            confirmPasswordRegTxtBx.TabIndex = 11;
            confirmPasswordRegTxtBx.TextChanged += confirmPasswordRegTxtBx_TextChanged;
            confirmPasswordRegTxtBx.Validating += confirmPasswordRegTxtBx_Validating;
            // 
            // registerSbmtBtn
            // 
            registerSbmtBtn.BackColor = Color.FromArgb(24, 59, 78);
            registerSbmtBtn.FlatAppearance.BorderColor = Color.FromArgb(245, 238, 220);
            registerSbmtBtn.FlatStyle = FlatStyle.Flat;
            registerSbmtBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            registerSbmtBtn.ForeColor = Color.FromArgb(245, 238, 220);
            registerSbmtBtn.Location = new Point(221, 313);
            registerSbmtBtn.Name = "registerSbmtBtn";
            registerSbmtBtn.Size = new Size(92, 31);
            registerSbmtBtn.TabIndex = 13;
            registerSbmtBtn.Text = "&Register";
            registerSbmtBtn.UseVisualStyleBackColor = false;
            registerSbmtBtn.Click += registerSbmtBtn_Click;
            // 
            // backToLoginBtn
            // 
            backToLoginBtn.BackColor = Color.FromArgb(24, 59, 78);
            backToLoginBtn.FlatAppearance.BorderColor = Color.FromArgb(245, 238, 220);
            backToLoginBtn.FlatStyle = FlatStyle.Flat;
            backToLoginBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            backToLoginBtn.ForeColor = Color.FromArgb(245, 238, 220);
            backToLoginBtn.Location = new Point(328, 347);
            backToLoginBtn.Name = "backToLoginBtn";
            backToLoginBtn.Size = new Size(61, 29);
            backToLoginBtn.TabIndex = 14;
            backToLoginBtn.Text = "&Login";
            backToLoginBtn.UseVisualStyleBackColor = false;
            backToLoginBtn.Click += backToLoginBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(24, 59, 78);
            label7.Location = new Point(137, 354);
            label7.Name = "label7";
            label7.Size = new Size(190, 16);
            label7.TabIndex = 15;
            label7.Text = "Already have an account?:";
            label7.Click += label7_Click;
            // 
            // regErrorProv
            // 
            regErrorProv.ContainerControl = this;
            // 
            // registrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(553, 450);
            Controls.Add(label7);
            Controls.Add(backToLoginBtn);
            Controls.Add(registerSbmtBtn);
            Controls.Add(label6);
            Controls.Add(confirmPasswordRegTxtBx);
            Controls.Add(label5);
            Controls.Add(passwordRegTxtBx);
            Controls.Add(label4);
            Controls.Add(userNameRegTxtBx);
            Controls.Add(label3);
            Controls.Add(phoneNumberRegTxtBx);
            Controls.Add(label2);
            Controls.Add(lastNameRegTxtBx);
            Controls.Add(label1);
            Controls.Add(firstNameRegTxtBx);
            Name = "registrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += registrationForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)regErrorProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameRegTxtBx;
        private Label label1;
        private Label label2;
        private TextBox lastNameRegTxtBx;
        private Label label3;
        private TextBox phoneNumberRegTxtBx;
        private Label label4;
        private TextBox userNameRegTxtBx;
        private Label label5;
        private TextBox passwordRegTxtBx;
        private Label label6;
        private TextBox confirmPasswordRegTxtBx;
        private Button registerSbmtBtn;
        private Button backToLoginBtn;
        private Label label7;
        private ErrorProvider regErrorProv;
    }
}