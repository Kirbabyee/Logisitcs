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
using System.IO;
using System.Drawing.Imaging;
using Mysqlx;

namespace logisticSystem
{
    public partial class Pendings : Form
    {
        public Pendings()
        {
            InitializeComponent();
        }
        private void Pendings_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void pendingBtn_Click(object sender, EventArgs e)
        {

        }

        private void fetchData()
        {
            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
            {
                try
                {
                    conn.Open();
                    String query = "select user_id as ID, concat(first_name, ' ', last_name) as NAME, DOCUMENT_FRONTPAGE, DOCUMENT_BACKPAGE, phone_number, email, user_type from user_accounts where status = 'Pending'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    displayPendingUser.RowTemplate.Height = 200;
                    displayPendingUser.AllowUserToAddRows = false;

                    
                    displayPendingUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    displayPendingUser.DataSource = table;

                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol = (DataGridViewImageColumn)displayPendingUser.Columns[2];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    imgCol = (DataGridViewImageColumn)displayPendingUser.Columns[3];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    displayPendingUser.Columns[0].Visible = false;
                    displayPendingUser.Columns[4].Visible = false;
                    displayPendingUser.Columns[5].Visible = false;
                    displayPendingUser.Columns[6].Visible = false;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int user = int.Parse(userID.Text);
            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("update user_accounts set status = 'Approved' where user_id = @userID", conn);
                    {
                        cmd.Parameters.AddWithValue("@userID", user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully", "APPROVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adminPage adminPage = new adminPage();
                        adminPage.Show();
                        this.Close();
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: " + a.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void displayPendingUser_Click(object sender, EventArgs e)
        {
            Byte[] img1 = (Byte[])displayPendingUser.CurrentRow.Cells[2].Value;
            Byte[] img2 = (Byte[])displayPendingUser.CurrentRow.Cells[3].Value;

            MemoryStream ms1 = new MemoryStream(img1);
            MemoryStream ms2 = new MemoryStream(img2);

            documentFrontPage.Image = Image.FromStream(ms1);
            documentBackPage.Image = Image.FromStream(ms2);

            userName.Visible = true;
            userName.Text = displayPendingUser.CurrentRow.Cells[1].Value.ToString();

            userEmail.Visible = true;
            userEmail.Text = displayPendingUser.CurrentRow.Cells[5].Value.ToString();

            userPhoneNumber.Visible = true;
            userPhoneNumber.Text = displayPendingUser.CurrentRow.Cells[4].Value.ToString();

            userType.Visible = true;
            userType.Text = displayPendingUser.CurrentRow.Cells[6].Value.ToString();

            frontPageLabel.Visible = true;
            backPageLabel.Visible = true;

            userID.Text = displayPendingUser.CurrentRow.Cells[0].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            int user = int.Parse(userID.Text);
            using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("update user_accounts set status = 'Rejected' where user_id = @userID", conn);
                    {
                        cmd.Parameters.AddWithValue("@userID", user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adminPage adminPage = new adminPage();
                        adminPage.Show();
                        this.Close();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: " + a.Message);
                }
            }
        }
    }
}
