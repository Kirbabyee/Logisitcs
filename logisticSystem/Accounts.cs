using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace logisticSystem
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            adminPage adminPage = new adminPage();
            adminPage.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadData()
        {
            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
            {
                try
                {
                    conn.Open();
                    String query = "select user_id as ID, concat(first_name, ' ', last_name) as NAME, EMAIL, PHONE_NUMBER, USER_TYPE from user_accounts";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    displayUsers.AllowUserToAddRows = false;
                    displayUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    displayUsers.DataSource = table;
                    displayUsers.Columns[0].Visible = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pendings pending = new Pendings();
            pending.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int user = int.Parse(userID.Text);
            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from user_accounts where user_id = @userID", conn);
                    {
                        cmd.Parameters.AddWithValue("@userID", user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: " + a.Message);
                }
            }
        }

        private void userID_Click(object sender, EventArgs e)
        {

        }

        private void displayUsers_Click(object sender, EventArgs e)
        {
            userEmail.Visible = true;
            userPhoneNumber.Visible = true;
            userType.Visible = true;
            userName.Visible = true;

            userID.Text = displayUsers.CurrentRow.Cells[0].Value.ToString();
            userName.Text = displayUsers.CurrentRow.Cells[1].Value.ToString();
            userEmail.Text = displayUsers.CurrentRow.Cells[2].Value.ToString();
            userPhoneNumber.Text = displayUsers.CurrentRow.Cells[3].Value.ToString();
            userType.Text = displayUsers.CurrentRow.Cells[4].Value.ToString();
            removeBtn.Visible = true;
        }

        private void userType_Click(object sender, EventArgs e)
        {

        }

        private void userType_Click_1(object sender, EventArgs e)
        {

        }

        private void userName_Click_1(object sender, EventArgs e)
        {

        }
    }
}
