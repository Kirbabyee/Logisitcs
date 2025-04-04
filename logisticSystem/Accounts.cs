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
                    String query = "select * from user_accounts";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }
    }
}
