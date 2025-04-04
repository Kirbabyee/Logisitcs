namespace logisticSystem
{
    partial class adminPage
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
            userGreetLabel = new Label();
            logoutButton = new Button();
            button2 = new Button();
            button1 = new Button();
            splitter1 = new Splitter();
            dashboardBtn = new Button();
            pendingBtn = new Button();
            SuspendLayout();
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
            userGreetLabel.Size = new Size(166, 88);
            userGreetLabel.TabIndex = 7;
            userGreetLabel.Text = "Hello, Admin";
            userGreetLabel.TextAlign = ContentAlignment.MiddleCenter;
            userGreetLabel.Click += userGreetLabel_Click;
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
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(39, 84, 138);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(245, 238, 220);
            button2.Location = new Point(0, 183);
            button2.Name = "button2";
            button2.Size = new Size(166, 30);
            button2.TabIndex = 6;
            button2.Text = "Accounts";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 84, 138);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(245, 238, 220);
            button1.Location = new Point(0, 147);
            button1.Name = "button1";
            button1.Size = new Size(166, 30);
            button1.TabIndex = 5;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(166, 450);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(24, 59, 78);
            dashboardBtn.FlatStyle = FlatStyle.Popup;
            dashboardBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.FromArgb(245, 238, 220);
            dashboardBtn.Location = new Point(0, 111);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(166, 30);
            dashboardBtn.TabIndex = 9;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
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
            pendingBtn.TabIndex = 18;
            pendingBtn.Text = "Pendings";
            pendingBtn.UseVisualStyleBackColor = false;
            pendingBtn.Click += pendingBtn_Click;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(800, 450);
            Controls.Add(pendingBtn);
            Controls.Add(dashboardBtn);
            Controls.Add(userGreetLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(logoutButton);
            Controls.Add(splitter1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += mainPage_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label userGreetLabel;
        private Button logoutButton;
        private Button button2;
        private Button button1;
        private Splitter splitter1;
        private Button dashboardBtn;
        private Button pendingBtn;
    }
}