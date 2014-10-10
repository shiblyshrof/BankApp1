using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankUI : Form
    {
        private Customer aCustomer;
        private Account anAccount;

        public BankUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();

            aCustomer.CustomerName = CustomerNameEntrytextBox.Text;
            aCustomer.Email = EmailEntrytextBox.Text;

            anAccount = new Account(AccontNumberEntrytextBox.Text,OpeningDateEntrytextBox.Text);
            aCustomer.Account1 = anAccount;
            MessageBox.Show("save");

        }

        private void ShowMeDetailsButton_Click(object sender, EventArgs e)
        {
            CustomerNameShowtextBox.Text = aCustomer.CustomerName;
            EmailShowtextBox.Text = aCustomer.Email;
            OpeningDateShowtextBox.Text = aCustomer.Account1.OpeningDate;
            AccountNumberShowtextBox.Text = aCustomer.Account1.Number;
            BalanceShowtextBox.Text = aCustomer.Account1.Balance.ToString();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
         
           // aCustomer.Account1.Deposit(Convert.ToDouble(AmounttextBox.Text));
            anAccount.Deposit(Convert.ToDouble(AmounttextBox.Text));
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            anAccount.Withdraw(Convert.ToDouble(AmounttextBox.Text));
        }
    }
}
