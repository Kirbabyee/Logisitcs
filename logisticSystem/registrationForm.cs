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
using Mysqlx.Cursor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logisticSystem
{
    public partial class registrationForm : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER= LOCALHOST;DATABASE= logistic_system;UID= root, PASSWORD= ");
        public registrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {

        }

        private void registrationForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registerSbmtBtn_Click(object sender, EventArgs e)
        {
            // Declaring the textboxes
            string firstName = firstNameRegTxtBx.Text;
            string lastName = lastNameRegTxtBx.Text;
            string phoneNumber = phoneNumberRegTxtBx.Text;
            string userName = userNameRegTxtBx.Text;
            string password = passwordRegTxtBx.Text;
            string confirmPassword = confirmPasswordRegTxtBx.Text;
            this.ValidateChildren(); // Validate all the text boxes before continuing
            if (AreAllFieldsValid())
            {
                using (MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD="))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into user_accounts (first_name, last_name, username, phone_number, password) values(@first_name, @last_name, @username, @phone_number, @password);", conn);
                    {
                        // Insert a value to the parameter
                        cmd.Parameters.AddWithValue("@first_name", firstName);
                        cmd.Parameters.AddWithValue("@last_name", lastName);
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery(); // Execute the query
                        MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Success message
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill up all empty fields", "Error Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information); // Validation message
            }
            
        }

        private void firstNameRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameRegTxtBx.Text)) // Check if the first name input is empty
            {
                regErrorProv.SetError(firstNameRegTxtBx, "Input Empty");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(firstNameRegTxtBx.Text, "^[a-zA-Z]")) // Check if the first name input is only letter
            {
                regErrorProv.SetError(firstNameRegTxtBx, "Input Invalid");
            }
            else
            {
                regErrorProv.SetError(firstNameRegTxtBx, null);
            }
        }

        private void lastNameRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lastNameRegTxtBx.Text)) // Check if the last name input is empty
            {
                regErrorProv.SetError(lastNameRegTxtBx, "Input Empty");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(lastNameRegTxtBx.Text, "^[a-zA-Z]")) // Check if the last name input is only letter
            {
                regErrorProv.SetError(lastNameRegTxtBx, "Input Invalid");
            }
            else
            {
                regErrorProv.SetError(lastNameRegTxtBx, null);
            }
        }

        private void phoneNumberRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumberRegTxtBx.Text)) // Check if the phone number input is empty
            {
                regErrorProv.SetError(phoneNumberRegTxtBx, "Input Empty");
            }
            else if (phoneNumberRegTxtBx.Text.Length != 11) // Check if the phone number input is equal to 11 numbers
            {
                regErrorProv.SetError(phoneNumberRegTxtBx, "Number should be 11 characters long");
            }
            else if (!phoneNumberRegTxtBx.Text.StartsWith("09")) // Check if the phone number starts with '09'
            {
                regErrorProv.SetError(phoneNumberRegTxtBx, "Number should starts with 09");
            }
            else
            {
                regErrorProv.SetError(phoneNumberRegTxtBx, null);
            }
        }

        private void phoneNumberRegTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Disable the letter input in phone number textbox
            {
                e.Handled = true;
            }
        }

        private void userNameRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (userNameExist(userNameRegTxtBx.Text)) // Check if the entered username already exist in the database
            {
                regErrorProv.SetError(userNameRegTxtBx, "Username already taken"); 
            }
            else if (string.IsNullOrEmpty(userNameRegTxtBx.Text)) // Check if the username input is empty
            {
                regErrorProv.SetError(userNameRegTxtBx, "Input Empty");
            }
            else
            {
                regErrorProv.SetError(userNameRegTxtBx, null);
            }
        }
        private void passwordRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordRegTxtBx.Text)) // Check if the password input is empty
            {
                regErrorProv.SetError(passwordRegTxtBx, "Input Empty");
            }
            else if (passwordRegTxtBx.Text.Length < 8) // Check if the password contains 8 and above characters
            {
                regErrorProv.SetError(passwordRegTxtBx, "Password Weak");
            }
            else
            {
                regErrorProv.SetError(passwordRegTxtBx, null);
            }
        }

        private void confirmPasswordRegTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (confirmPasswordRegTxtBx.Text != passwordRegTxtBx.Text) // Check if the confirm password input is the same with the inputed password
            {
                regErrorProv.SetError(confirmPasswordRegTxtBx, "Password not same");
            }
            else if (string.IsNullOrEmpty(confirmPasswordRegTxtBx.Text)) // Check if the confirm password input is not empty
            {
                regErrorProv.SetError(confirmPasswordRegTxtBx, "Input Empty");
            }
            else
            {
                regErrorProv.SetError(confirmPasswordRegTxtBx, null);
            }
        }

        public static bool userNameExist(string userName)
        {
            string connString = "SERVER=localhost;DATABASE=logistic_system;UID=root;PASSWORD=;"; // Connecting to database

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM user_accounts WHERE username = @username"; // Check if the username exists in the database query

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    int count = Convert.ToInt32(cmd.ExecuteScalar()); // Get count of matching usernames
                    return count > 0; // Returns true if username exists
                }
            }
        }
        private bool AreAllFieldsValid()
        {
            foreach (Control c in this.Controls)
            {
                if (regErrorProv.GetError(c) != "") // If any field has an error
                {
                    return false; // Validation failed
                }
            }
            return true; // All fields are valid
        }

        private void confirmPasswordRegTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
