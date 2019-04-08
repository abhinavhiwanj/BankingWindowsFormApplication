using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            new DepositForm().Show();
            this.Hide();
        }

        private void PassbookButton_Click(object sender, EventArgs e)
        {
            new PassbookForm().Show();
            this.Hide();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            new WithDrawForm().Show();
            this.Hide();
        }

        private void MoneyTransferButton_Click(object sender, EventArgs e)
        {
            new MoneyTransferForm().Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
