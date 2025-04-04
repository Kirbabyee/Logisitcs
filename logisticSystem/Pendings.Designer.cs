namespace logisticSystem
{
    partial class Pendings
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
            documentFrontPage = new PictureBox();
            documentBackPage = new PictureBox();
            approveBtn = new Button();
            rejectBtn = new Button();
            displayPendingUser = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            userName = new Label();
            userEmail = new Label();
            userPhoneNumber = new Label();
            label4 = new Label();
            userType = new Label();
            label6 = new Label();
            frontPageLabel = new Label();
            backPageLabel = new Label();
            userID = new Label();
            ((System.ComponentModel.ISupportInitialize)documentFrontPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentBackPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayPendingUser).BeginInit();
            SuspendLayout();
            // 
            // documentFrontPage
            // 
            documentFrontPage.Location = new Point(42, 25);
            documentFrontPage.Margin = new Padding(4);
            documentFrontPage.Name = "documentFrontPage";
            documentFrontPage.Size = new Size(270, 324);
            documentFrontPage.SizeMode = PictureBoxSizeMode.StretchImage;
            documentFrontPage.TabIndex = 30;
            documentFrontPage.TabStop = false;
            documentFrontPage.Click += pictureBox1_Click;
            // 
            // documentBackPage
            // 
            documentBackPage.Location = new Point(320, 25);
            documentBackPage.Margin = new Padding(4);
            documentBackPage.Name = "documentBackPage";
            documentBackPage.Size = new Size(270, 324);
            documentBackPage.SizeMode = PictureBoxSizeMode.StretchImage;
            documentBackPage.TabIndex = 31;
            documentBackPage.TabStop = false;
            // 
            // approveBtn
            // 
            approveBtn.BackColor = Color.Green;
            approveBtn.FlatStyle = FlatStyle.Flat;
            approveBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            approveBtn.ForeColor = Color.FromArgb(245, 238, 220);
            approveBtn.Location = new Point(42, 523);
            approveBtn.Margin = new Padding(4);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(139, 39);
            approveBtn.TabIndex = 32;
            approveBtn.Text = "APPROVE";
            approveBtn.UseVisualStyleBackColor = false;
            approveBtn.Click += approveBtn_Click;
            // 
            // rejectBtn
            // 
            rejectBtn.BackColor = Color.FromArgb(192, 0, 0);
            rejectBtn.FlatStyle = FlatStyle.Flat;
            rejectBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            rejectBtn.ForeColor = Color.FromArgb(245, 238, 220);
            rejectBtn.Location = new Point(42, 573);
            rejectBtn.Margin = new Padding(4);
            rejectBtn.Name = "rejectBtn";
            rejectBtn.Size = new Size(139, 39);
            rejectBtn.TabIndex = 33;
            rejectBtn.Text = "REJECT";
            rejectBtn.UseVisualStyleBackColor = false;
            rejectBtn.Click += rejectBtn_Click;
            // 
            // displayPendingUser
            // 
            displayPendingUser.BackgroundColor = Color.FromArgb(245, 238, 220);
            displayPendingUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displayPendingUser.Location = new Point(622, 14);
            displayPendingUser.Margin = new Padding(4);
            displayPendingUser.Name = "displayPendingUser";
            displayPendingUser.Size = new Size(736, 610);
            displayPendingUser.TabIndex = 34;
            displayPendingUser.CellContentClick += dataGridView1_CellContentClick;
            displayPendingUser.Click += displayPendingUser_Click;
            // 
            // label1
            // 
            label1.Location = new Point(42, 386);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 35;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(42, 417);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 36;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Microsoft Sans Serif", 11.25F);
            userName.Location = new Point(110, 386);
            userName.Name = "userName";
            userName.Size = new Size(46, 18);
            userName.TabIndex = 37;
            userName.Text = "label3";
            userName.Visible = false;
            userName.Click += label3_Click;
            // 
            // userEmail
            // 
            userEmail.AutoSize = true;
            userEmail.Font = new Font("Microsoft Sans Serif", 11.25F);
            userEmail.Location = new Point(110, 417);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(46, 18);
            userEmail.TabIndex = 38;
            userEmail.Text = "label4";
            userEmail.Visible = false;
            // 
            // userPhoneNumber
            // 
            userPhoneNumber.AutoSize = true;
            userPhoneNumber.Font = new Font("Microsoft Sans Serif", 11.25F);
            userPhoneNumber.Location = new Point(174, 450);
            userPhoneNumber.Name = "userPhoneNumber";
            userPhoneNumber.Size = new Size(46, 18);
            userPhoneNumber.TabIndex = 40;
            userPhoneNumber.Text = "label4";
            userPhoneNumber.Visible = false;
            // 
            // label4
            // 
            label4.Location = new Point(42, 450);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 39;
            label4.Text = "Phone Number:";
            label4.Click += label4_Click;
            // 
            // userType
            // 
            userType.AutoSize = true;
            userType.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userType.Location = new Point(140, 483);
            userType.Name = "userType";
            userType.Size = new Size(46, 18);
            userType.TabIndex = 42;
            userType.Text = "label4";
            userType.Visible = false;
            userType.Click += label5_Click;
            // 
            // label6
            // 
            label6.Location = new Point(42, 483);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 41;
            label6.Text = "User Type:";
            label6.Click += label6_Click;
            // 
            // frontPageLabel
            // 
            frontPageLabel.AutoSize = true;
            frontPageLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frontPageLabel.Location = new Point(124, 3);
            frontPageLabel.Name = "frontPageLabel";
            frontPageLabel.Size = new Size(115, 18);
            frontPageLabel.TabIndex = 43;
            frontPageLabel.Text = "FRONT PAGE";
            frontPageLabel.Visible = false;
            // 
            // backPageLabel
            // 
            backPageLabel.AutoSize = true;
            backPageLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backPageLabel.Location = new Point(401, 3);
            backPageLabel.Name = "backPageLabel";
            backPageLabel.Size = new Size(102, 18);
            backPageLabel.TabIndex = 44;
            backPageLabel.Text = "BACK PAGE";
            backPageLabel.Visible = false;
            backPageLabel.Click += label5_Click_1;
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.Font = new Font("Microsoft Sans Serif", 11.25F);
            userID.Location = new Point(42, 360);
            userID.Name = "userID";
            userID.Size = new Size(51, 18);
            userID.TabIndex = 45;
            userID.Text = "userID";
            userID.Visible = false;
            // 
            // Pendings
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(1371, 636);
            Controls.Add(userID);
            Controls.Add(backPageLabel);
            Controls.Add(frontPageLabel);
            Controls.Add(userType);
            Controls.Add(label6);
            Controls.Add(userPhoneNumber);
            Controls.Add(label4);
            Controls.Add(userEmail);
            Controls.Add(userName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(displayPendingUser);
            Controls.Add(rejectBtn);
            Controls.Add(approveBtn);
            Controls.Add(documentBackPage);
            Controls.Add(documentFrontPage);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Pendings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pendings";
            Load += Pendings_Load;
            ((System.ComponentModel.ISupportInitialize)documentFrontPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentBackPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayPendingUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox documentFrontPage;
        private PictureBox documentBackPage;
        private Button approveBtn;
        private Button rejectBtn;
        private DataGridView displayPendingUser;
        public Label label1;
        public Label label2;
        private Label userName;
        private Label userEmail;
        private Label userPhoneNumber;
        public Label label4;
        private Label userType;
        public Label label6;
        private Label frontPageLabel;
        private Label backPageLabel;
        private Label userID;
    }
}