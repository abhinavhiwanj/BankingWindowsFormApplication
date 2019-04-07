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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var sqlConnection = new SqlConnection("Data Source=DESKTOP-TRC58QD\\SQLEXPRESS;Initial Catalog=BankApp;Integrated Security=true;");
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

            this.Close();
            LoginInfo.OptionForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
