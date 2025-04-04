
namespace logisticSystem
{
    partial class Accounts
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
            displayUsers = new DataGridView();
            logoutButton = new Button();
            userGreetLabel = new Label();
            dashboardBtn = new Button();
            orderBtn = new Button();
            accountBtn = new Button();
            pendingBtn = new Button();
            splitter1 = new Splitter();
            removeBtn = new Button();
            label1 = new Label();
            userID = new Label();
            userName = new Label();
            userEmail = new Label();
            userPhoneNumber = new Label();
            userType = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)displayUsers).BeginInit();
            SuspendLayout();
            // 
            // displayUsers
            // 
            displayUsers.BackgroundColor = Color.FromArgb(245, 238, 220);
            displayUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            displayUsers.Location = new Point(172, 9);
            displayUsers.Name = "displayUsers";
            displayUsers.Size = new Size(708, 399);
            displayUsers.TabIndex = 16;
            displayUsers.CellContentClick += dataGridView1_CellContentClick;
            displayUsers.Click += displayUsers_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(39, 84, 138);
            logoutButton.FlatAppearance.BorderColor = Color.FromArgb(221, 168, 83);
            logoutButton.FlatStyle = FlatStyle.Popup;
            logoutButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.FromArgb(245, 238, 220);
            logoutButton.Location = new Point(0, 391);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(166, 29);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // userGreetLabel
            // 
            userGreetLabel.BackColor = Color.FromArgb(39, 84, 138);
            userGreetLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userGreetLabel.ForeColor = Color.FromArgb(245, 238, 220);
            userGreetLabel.Location = new Point(0, 9);
            userGreetLabel.Margin = new Padding(0);
            userGreetLabel.MaximumSize = new Size(170, 0);
            userGreetLabel.Name = "userGreetLabel";
            userGreetLabel.Padding = new Padding(10);
            userGreetLabel.Size = new Size(166, 0);
            userGreetLabel.TabIndex = 13;
            userGreetLabel.Text = "Hello, Admin";
            userGreetLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(39, 84, 138);
            dashboardBtn.FlatStyle = FlatStyle.Popup;
            dashboardBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.FromArgb(245, 238, 220);
            dashboardBtn.Location = new Point(0, 111);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(166, 30);
            dashboardBtn.TabIndex = 15;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // orderBtn
            // 
            orderBtn.BackColor = Color.FromArgb(39, 84, 138);
            orderBtn.FlatStyle = FlatStyle.Popup;
            orderBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderBtn.ForeColor = Color.FromArgb(245, 238, 220);
            orderBtn.Location = new Point(0, 147);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(166, 30);
            orderBtn.TabIndex = 11;
            orderBtn.Text = "Orders";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += button1_Click;
            // 
            // accountBtn
            // 
            accountBtn.BackColor = Color.FromArgb(24, 59, 78);
            accountBtn.FlatStyle = FlatStyle.Popup;
            accountBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountBtn.ForeColor = Color.FromArgb(245, 238, 220);
            accountBtn.Location = new Point(0, 183);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(166, 30);
            accountBtn.TabIndex = 12;
            accountBtn.Text = "Accounts";
            accountBtn.UseVisualStyleBackColor = false;
            accountBtn.Click += button2_Click;
            // 
            // pendingBtn
            // 
            pendingBtn.BackColor = Color.FromArgb(39, 84, 138);
            pendingBtn.FlatStyle = FlatStyle.Popup;
            pendingBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingBtn.ForeColor = Color.FromArgb(245, 238, 220);
            pendingBtn.Location = new Point(0, 219);
            pendingBtn.Name = "pendingBtn";
            pendingBtn.Size = new Size(166, 30);
            pendingBtn.TabIndex = 17;
            pendingBtn.Text = "Pendings";
            pendingBtn.UseVisualStyleBackColor = false;
            pendingBtn.Click += button3_Click;
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(166, 459);
            splitter1.TabIndex = 14;
            splitter1.TabStop = false;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Red;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(714, 414);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(144, 33);
            removeBtn.TabIndex = 18;
            removeBtn.Text = "REMOVE";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Visible = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(39, 84, 138);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 238, 220);
            label1.Location = new Point(0, 9);
            label1.Margin = new Padding(0);
            label1.MaximumSize = new Size(170, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(166, 0);
            label1.TabIndex = 19;
            label1.Text = "Hello, Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.Location = new Point(172, 423);
            userID.Name = "userID";
            userID.Size = new Size(43, 15);
            userID.TabIndex = 20;
            userID.Text = "userID";
            userID.Visible = false;
            userID.Click += userID_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            userName.Location = new Point(240, 423);
            userName.Name = "userName";
            userName.Size = new Size(73, 15);
            userName.TabIndex = 21;
            userName.Text = "userName";
            userName.Visible = false;
            userName.Click += userName_Click_1;
            // 
            // userEmail
            // 
            userEmail.AutoSize = true;
            userEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            userEmail.Location = new Point(351, 423);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(43, 15);
            userEmail.TabIndex = 22;
            userEmail.Text = "email";
            userEmail.Visible = false;
            userEmail.Click += userEmail_Click_1;
            // 
            // userPhoneNumber
            // 
            userPhoneNumber.AutoSize = true;
            userPhoneNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            userPhoneNumber.Location = new Point(453, 423);
            userPhoneNumber.Name = "userPhoneNumber";
            userPhoneNumber.Size = new Size(98, 15);
            userPhoneNumber.TabIndex = 23;
            userPhoneNumber.Text = "phoneNumber";
            userPhoneNumber.Visible = false;
            userPhoneNumber.Click += userPhoneNumber_Click_1;
            // 
            // userType
            // 
            userType.AutoSize = true;
            userType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            userType.Location = new Point(588, 423);
            userType.Name = "userType";
            userType.Size = new Size(65, 15);
            userType.TabIndex = 24;
            userType.Text = "userType";
            userType.Visible = false;
            userType.Click += userType_Click_1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(39, 84, 138);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(245, 238, 220);
            label2.Location = new Point(0, 9);
            label2.Margin = new Padding(0);
            label2.MaximumSize = new Size(170, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(166, 88);
            label2.TabIndex = 25;
            label2.Text = "Hello, Admin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(886, 459);
            Controls.Add(label2);
            Controls.Add(userType);
            Controls.Add(userPhoneNumber);
            Controls.Add(userEmail);
            Controls.Add(userName);
            Controls.Add(userID);
            Controls.Add(label1);
            Controls.Add(removeBtn);
            Controls.Add(pendingBtn);
            Controls.Add(displayUsers);
            Controls.Add(dashboardBtn);
            Controls.Add(userGreetLabel);
            Controls.Add(accountBtn);
            Controls.Add(orderBtn);
            Controls.Add(logoutButton);
            Controls.Add(splitter1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)displayUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void userPhoneNumber_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void userEmail_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView displayUsers;
        private Button logoutButton;
        private Label userGreetLabel;
        private Button dashboardBtn;
        private Button orderBtn;
        private Button accountBtn;
        private Button pendingBtn;
        private Splitter splitter1;
        private Button removeBtn;
        private Label label1;
        private Label userID;
        private Label userName;
        private Label userEmail;
        private Label userPhoneNumber;
        private Label userType;
        private Label label2;
    }
}