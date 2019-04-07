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
    public partial class PassbookForm : Form
    {
        public PassbookForm()
        {
            InitializeComponent();
        }

        private void PassbookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankAppDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.bankAppDataSet.Transaction);

        }
    }
}
