using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bankproject
{
    public partial class Form1 : Form
    {
        List<Accounts> AllAccs = new List<Accounts>();

        public Form1()
        {
            InitializeComponent();
            DisplayAccounts();
            ViewAccount();
        }


        private void btnEveryday_Click(object sender, EventArgs e)
        {
            DisplayAccounts();
            ViewAccount();
            Everyday v = new Everyday("Everyday Account");
            AllAccs.Add(v);
            listBox2.Items.Add(v);
        }

        private void btnInvestment_Click(object sender, EventArgs e)
        {
            DisplayAccounts();
            ViewAccount();
            Investment i = new Investment("Investment Account");
            AllAccs.Add(i);
            listBox2.Items.Add(i);
        }

        private void btnOmni_Click(object sender, EventArgs e)
        {
            DisplayAccounts();
            ViewAccount();
            Omni o = new Omni("Omni Account");
            AllAccs.Add(o);
            listBox2.Items.Add(o);
        }

        private void ViewAccount()
        {
            DisplayAccounts();
            Accounts a;
            Everyday v;
            Investment i;
            Omni o;

        }
        public void DisplayAccounts()
        {
            listBox2.Items.Clear();
            foreach (Accounts a in AllAccs)
            {
                listBox2.Items.Add(a);
            }
        }

        private void accountDetails_Click(object sender, EventArgs e)
        {

            accountInfo_TextChanged(sender, e);

        }

        private void accountInfo_TextChanged(object sender, EventArgs e)
        {
            Accounts a = null;
            string acc;
            int.Parse(accountDetails.Text);

            bool btnEveryday_Click = true;
            if (btnEveryday_Click == true)
            {
                accountInfo.Text += "Name: ";
                accountInfo.Text += "Address: ";
                accountInfo.Text += "Account Type: ";
                accountInfo.Text += "NoFees: ";
            }
            if (a == null)
            {
                AllAccs.Add(a);
            }

            bool btnInvestment_Click = true;
            if (btnInvestment_Click == true)
            {
                accountInfo.Text += "Name: ";
                accountInfo.Text += "Address: ";
                accountInfo.Text += "Account Type: ";
            }
            if (a == null)
            {
                AllAccs.Add(a);
            }

            bool btnOmni_Click = true;
            if (btnOmni_Click == true)
            {
                accountInfo.Text += "Name: ";
                accountInfo.Text += "Address: ";
                accountInfo.Text += "Account Type: ";
            }

            if (a == null)
            {
                AllAccs.Add(a);
            }
        }
        private void withdrawMoney_Click(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool withdrawMoney_Click = true;
            if (withdrawMoney_Click == true)
            {
                listBox1.Items.Insert(1, "Account: ");
                listBox1.Items.Insert(2, "Name: ");
                listBox1.Items.Insert(3, "Amount in Bank: ");
                listBox1.Items.Insert(4, "Withdrawn Amount:  ");
            }
            else { Console.WriteLine("Error, please try again"); };
        }
    }
}