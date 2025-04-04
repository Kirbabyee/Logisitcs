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
            dashboardBtn = new Button();
            userGreetLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            logoutButton = new Button();
            splitter1 = new Splitter();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            userGreetLabel.TabIndex = 13;
            userGreetLabel.Text = "Hello, Admin";
            userGreetLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 59, 78);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(245, 238, 220);
            button2.Location = new Point(0, 183);
            button2.Name = "button2";
            button2.Size = new Size(166, 30);
            button2.TabIndex = 12;
            button2.Text = "Accounts";
            button2.UseVisualStyleBackColor = false;
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
            button1.TabIndex = 11;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = false;
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
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(166, 450);
            splitter1.TabIndex = 14;
            splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 364);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 238, 220);
            ClientSize = new Size(1053, 450);
            Controls.Add(dataGridView1);
            Controls.Add(dashboardBtn);
            Controls.Add(userGreetLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(logoutButton);
            Controls.Add(splitter1);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button dashboardBtn;
        private Label userGreetLabel;
        private Button button2;
        private Button button1;
        private Button logoutButton;
        private Splitter splitter1;
        private DataGridView dataGridView1;
    }
}