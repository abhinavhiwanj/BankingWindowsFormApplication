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
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var sqlConnection = new SqlConnection("Data Source=DESKTOP-TRC58QD\\SQLEXPRESS;Initial Catalog=BankApp;Integrated Security=true;");
            sqlConnection.Open();

            var getInfo = new SqlCommand("select password,Account_Number,Balance from account_information where [Email]='" + EmailTextBox.Text+"'", sqlConnection);
            SqlDataReader sqlDataReader = getInfo.ExecuteReader();
            sqlDataReader.Read();
            if(sqlDataReader.HasRows)
            {
                var password = sqlDataReader.GetValue(0).ToString();
                if(password.Equals(PasswordTextBox.Text))
                {
                    LoginInfo.Email = EmailTextBox.Text;
                    LoginInfo.AccountNumber = sqlDataReader.GetValue(1).ToString();
                    LoginInfo.Balance = Int32.Parse(sqlDataReader.GetValue(2).ToString());
                    LoginInfo.OptionForm.Show();
                    this.Hide();
                } else
                {
                    MessageLabel.Text = "Incorrect Password";
                }
            } else
            {
                MessageLabel.Text = "User Account Not Found";
            }

            sqlConnection.Close();
        }
    }
}
