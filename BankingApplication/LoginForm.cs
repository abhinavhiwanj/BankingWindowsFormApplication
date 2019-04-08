using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(EmailTextBox.Text == string.Empty)
                {
                    throw new Exception("Email cannot be Empty");
                }

                if (PasswordTextBox.Text == string.Empty)
                {
                    throw new Exception("Password cannot be Empty");
                }
                var sqlConnection = new SqlConnection("Data Source="+Consants.database+";Initial Catalog=BankApp;Integrated Security=true;");
                sqlConnection.Open();

                var getInfo = new SqlCommand("select password,Account_Number,Balance from account_information where [Email]='" + EmailTextBox.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = getInfo.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    var password = sqlDataReader.GetValue(0).ToString();
                    if (password.Equals(PasswordTextBox.Text))
                    {
                        LoginInfo.Email = EmailTextBox.Text;
                        LoginInfo.AccountNumber = sqlDataReader.GetValue(1).ToString();
                        LoginInfo.Balance = Int32.Parse(sqlDataReader.GetValue(2).ToString());
                        LoginInfo.OptionForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Incorrect Password");
                    }
                }
                else
                {
                    throw new Exception("User Account Not Found");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }
    }
}
