using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace logisticSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataGridView dataGridView1;

        private void emailLoginTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show(); // Show registration form when button is clicked
            this.Hide(); // Hide this form if button is clicked
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordLoginTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameLoginTxtBx.Text == "admin" && passwordLoginTxtBx.Text == "admin")
            {
                adminPage adminPage = new adminPage();
                adminPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enterPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void enterEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLoginTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLoginTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e) // Username login validation
        {
            if (string.IsNullOrEmpty(usernameLoginTxtBx.Text)) // Validate the username input if empty
            {
                errorProvider.SetError(usernameLoginTxtBx, "Input empty");
            }
            else
            {
                errorProvider.SetError(usernameLoginTxtBx, null);
            }
        }

        private void passwordLoginTxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e) // Password login validation
        {
            if(string.IsNullOrEmpty(passwordLoginTxtBx.Text)) // Validate the password input if empty
            {
                errorProvider.SetError(passwordLoginTxtBx, "Input Empty");
            }
            else
            {
                errorProvider.SetError(passwordLoginTxtBx, null);
            }
        }
        private bool AreAllFieldsValid()
        {
            foreach (Control c in this.Controls)
            {
                if (errorProvider.GetError(c) != "") // Check if error provider is not empty
                {
                    return false;
                }
            }
            return true; // Return true if the error provider is empty
        }
    }
}
