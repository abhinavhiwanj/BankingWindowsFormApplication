using System;
using System.Collections;
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
    public partial class PassbookForm : Form
    {
        Record[] records = new Record[1000];
        int count = 0;
        int numberOfRecord = 0;
        public PassbookForm()
        {
            InitializeComponent();
            blankPassbookLabel();
            var sqlConnection = new SqlConnection("Data Source=" + Consants.database + ";Initial Catalog=BankApp;Integrated Security=true;");
            sqlConnection.Open();

            var statement = new SqlCommand("select * from [Transaction] where Account_number="+LoginInfo.AccountNumber,sqlConnection);

            var dataReader = statement.ExecuteReader();

            while (dataReader.Read())
            {
                var record = new Record();

                record.TrasansactionType = dataReader.GetValue(1).ToString();
                record.TrasansactionAmount = Int32.Parse(dataReader.GetValue(2).ToString());
                record.Balance = Int32.Parse(dataReader.GetValue(3).ToString());
                record.Date = DateTime.Parse(dataReader.GetValue(4).ToString());

                records[numberOfRecord] = record;
                numberOfRecord++;
               
            }
            count += 5;
            displayPassbook(0);
        }

        private void displayPassbook(int startIndex)
        {
            if (startIndex < numberOfRecord && startIndex >= 0)
            {
                r1c1.Text = records[startIndex].TrasansactionType;
                r1c2.Text = records[startIndex].TrasansactionAmount.ToString();
                r1c3.Text = records[startIndex].Balance.ToString();
                r1c4.Text = records[startIndex].Date.ToString();
            }

            if (startIndex + 1 < numberOfRecord && startIndex >= 0)
            {
                r2c1.Text = records[startIndex + 1].TrasansactionType;
                r2c2.Text = records[startIndex + 1].TrasansactionAmount.ToString();
                r2c3.Text = records[startIndex + 1].Balance.ToString();
                r2c4.Text = records[startIndex + 1].Date.ToString();
            }

            if (startIndex + 2 < numberOfRecord && startIndex >= 0)
            {
                r3c1.Text = records[startIndex + 2].TrasansactionType;
                r3c2.Text = records[startIndex + 2].TrasansactionAmount.ToString();
                r3c3.Text = records[startIndex + 2].Balance.ToString();
                r3c4.Text = records[startIndex + 2].Date.ToString();
            }

            if (startIndex + 3 < numberOfRecord && startIndex >= 0)
            {
                r4c1.Text = records[startIndex + 3].TrasansactionType;
                r4c2.Text = records[startIndex + 3].TrasansactionAmount.ToString();
                r4c3.Text = records[startIndex + 3].Balance.ToString();
                r4c4.Text = records[startIndex + 3].Date.ToString();
            }

            if (startIndex + 4 < numberOfRecord && startIndex >= 0)
            {
                r5c1.Text = records[startIndex + 4].TrasansactionType;
                r5c2.Text = records[startIndex + 4].TrasansactionAmount.ToString();
                r5c3.Text = records[startIndex + 4].Balance.ToString();
                r5c4.Text = records[startIndex + 4].Date.ToString();
            }

            BackButton.Enabled = count == 5 ? false : true;
            NextButton.Enabled = numberOfRecord <= count ? false : true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            count += 5;
            blankPassbookLabel();
            displayPassbook(count - 5);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            blankPassbookLabel();
            count -= 5;
            displayPassbook(count - 5);
        }

        private void blankPassbookLabel()
        {
            r1c1.Text = string.Empty;
            r1c2.Text = string.Empty;
            r1c3.Text = string.Empty;
            r1c4.Text = string.Empty;

            r2c1.Text = string.Empty;
            r2c2.Text = string.Empty;
            r2c3.Text = string.Empty;
            r2c4.Text = string.Empty;

            r3c1.Text = string.Empty;
            r3c2.Text = string.Empty;
            r3c3.Text = string.Empty;
            r3c4.Text = string.Empty;

            r4c1.Text = string.Empty;
            r4c2.Text = string.Empty;
            r4c3.Text = string.Empty;
            r4c4.Text = string.Empty;

            r5c1.Text = string.Empty;
            r5c2.Text = string.Empty;
            r5c3.Text = string.Empty;
            r5c4.Text = string.Empty;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInfo.OptionForm.Show();
        }
    }
}
