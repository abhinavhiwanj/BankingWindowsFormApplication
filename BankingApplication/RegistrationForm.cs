using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankingApplication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateField();

                var sqlConnection = new SqlConnection("Data Source=" + Consants.database + ";Initial Catalog=BankApp;Integrated Security=true;");
                sqlConnection.Open();

                var infoInsertStatement = new SqlCommand("Insert into account_information values(@Name,@Email,@Password,@MobileNumber,@Gender,@Balance,@DOB)", sqlConnection);

                infoInsertStatement.Parameters.AddWithValue("@Name", NameTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@DOB", DOBTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@Gender", GenderTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@MobileNumber", MobileTextBox.Text);
                infoInsertStatement.Parameters.AddWithValue("@Balance", 0);

                infoInsertStatement.ExecuteNonQuery();
                sqlConnection.Close();

                this.Hide();
                new LoginForm().Show();
            }
            catch(Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        private void ValidateField()
        {
            if(NameTextBox.Text == string.Empty)
            {
                throw new Exception("Name cannot be Empty");
            }
            if(DOBTextBox.Text == string.Empty)
            {
                throw new Exception("DOB cannot be Empty");
            }
            if (EmailTextBox.Text == string.Empty)
            {
                throw new Exception("Email cannot be Empty");
            }
            if (PasswordTextBox.Text.Length < 5)
            {
                throw new Exception("Password should be at least 5 Character");
            }
            if (GenderTextBox.Text == string.Empty)
            {
                throw new Exception("Gender cannot be Empty");
            }
            if (MobileTextBox.Text == string.Empty)
            {
                throw new Exception("Mobile Number cannot be Empty");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
