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
    public partial class MoneyTransferForm : Form
    {
        public MoneyTransferForm()
        {
            InitializeComponent();
            BalanceMoneyLabel.Text = LoginInfo.Balance.ToString() + "/-";
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MoneyTransferTextBox.Text == string.Empty)
                {
                    throw new Exception("Cannnot be Empty");
                }

                if (Int32.Parse(MoneyTransferTextBox.Text) <= 0)
                {
                    throw new Exception("Cannnot be Less than or Equal to Null");
                }

                var sqlConnection = new SqlConnection("Data Source=" + Consants.database + ";Initial Catalog=BankApp;Integrated Security=true;");
                sqlConnection.Open();
                if (LoginInfo.Balance > Int32.Parse(MoneyTransferTextBox.Text))
                {
                    LoginInfo.Balance -= Int32.Parse(MoneyTransferTextBox.Text);
                    var insertCommand = new SqlCommand("Insert into [Transaction] values(@Account_Number,@Transaction_Type,@Transaction_Amount,@Balance,@Date)", sqlConnection);
                    insertCommand.Parameters.AddWithValue("@Account_Number", LoginInfo.AccountNumber);
                    insertCommand.Parameters.AddWithValue("@Transaction_Type", "Transfer To" + BenTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@Transaction_Amount", MoneyTransferTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@Balance", LoginInfo.Balance);
                    insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);

                    var updateCommand = new SqlCommand("update account_information set balance = " + LoginInfo.Balance + " where Email='" + LoginInfo.Email + "'", sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    updateCommand.ExecuteNonQuery();

                    var benAccountBalance = getBalance(Int32.Parse(BenTextBox.Text), sqlConnection);

                    var benInsertCommand = new SqlCommand("Insert into [Transaction] values(@Account_number,@Transaction_Type,@Transaction_Amount,@Balance,@Date)", sqlConnection);
                    benInsertCommand.Parameters.AddWithValue("@Account_number", Int32.Parse(BenTextBox.Text));
                    benInsertCommand.Parameters.AddWithValue("@Transaction_Type", "Transfer From" + LoginInfo.AccountNumber);
                    benInsertCommand.Parameters.AddWithValue("@Transaction_Amount", MoneyTransferTextBox.Text);
                    benInsertCommand.Parameters.AddWithValue("@Balance", benAccountBalance + Int32.Parse(MoneyTransferTextBox.Text));
                    benInsertCommand.Parameters.AddWithValue("@Date", DateTime.Now);

                    var benUpdateCommand = new SqlCommand("update account_information set Balance = " + (benAccountBalance + Int32.Parse(MoneyTransferTextBox.Text)) + " where Account_Number=" + BenTextBox.Text, sqlConnection);

                    benUpdateCommand.ExecuteNonQuery();
                    benInsertCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    this.Hide();
                    LoginInfo.OptionForm.Show();
                }
                else
                {
                    throw new Exception("Insufficent Balance");
                }
            }
            catch(Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }

        }

        private int getBalance(int account_number,SqlConnection sqlConnection)
        {
            var getBalanceStatement = new SqlCommand("select Balance from account_information where Account_Number=" + account_number, sqlConnection);
            using (var dr = getBalanceStatement.ExecuteReader())
            {
                dr.Read();
                if (dr.HasRows)
                {
                    return Int32.Parse(dr.GetValue(0).ToString());
                }
                throw new Exception("Account Not Avaliable");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginInfo.OptionForm.Show();
            this.Hide();
        }
    }
}
