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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepositMoneyTextBox.Text == string.Empty)
                {
                    throw new Exception("Cannnot be Empty");
                }

                if (Int32.Parse(DepositMoneyTextBox.Text) <= 0)
                {
                    throw new Exception("Cannnot be Less than or Equal to Null");
                }

                var sqlConnection = new SqlConnection("Data Source=" + Consants.database + ";Initial Catalog=BankApp;Integrated Security=true;");
                sqlConnection.Open();
                LoginInfo.Balance += Int32.Parse(DepositMoneyTextBox.Text);
                var insertCommand = new SqlCommand("Insert into [Transaction] values(@Account_Number,@Transaction_Type,@Transaction_Amount,@Balance,@Date)", sqlConnection);
                insertCommand.Parameters.AddWithValue("@Account_Number", LoginInfo.AccountNumber);
                insertCommand.Parameters.AddWithValue("@Transaction_Type", "Deposit");
                insertCommand.Parameters.AddWithValue("@Transaction_Amount", DepositMoneyTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Balance", LoginInfo.Balance);
                insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);

                var updateCommand = new SqlCommand("update account_information set balance = " + LoginInfo.Balance + " where Email='" + LoginInfo.Email + "'", sqlConnection);

                insertCommand.ExecuteNonQuery();
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();

                this.Close();
                LoginInfo.OptionForm.Show();
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            BalanceMoneyLabel.Text = LoginInfo.Balance.ToString()+ "/-";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginInfo.OptionForm.Show();
            this.Close();
        }
    }
}
