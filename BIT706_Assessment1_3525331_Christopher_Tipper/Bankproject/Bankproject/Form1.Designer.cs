namespace Bankproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOmni = new Button();
            btnInvestment = new Button();
            btnEveryday = new Button();
            accountDetails = new Button();
            withdrawMoney = new Button();
            listBox1 = new ListBox();
            btnViewAccount = new Button();
            listBox2 = new ListBox();
            accountInfo = new RichTextBox();
            btnDeposit = new Button();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // btnOmni
            // 
            btnOmni.Location = new Point(14, 226);
            btnOmni.Name = "btnOmni";
            btnOmni.Size = new Size(122, 53);
            btnOmni.TabIndex = 12;
            btnOmni.Text = "Omni";
            btnOmni.UseVisualStyleBackColor = true;
            // 
            // btnInvestment
            // 
            btnInvestment.Location = new Point(14, 116);
            btnInvestment.Name = "btnInvestment";
            btnInvestment.Size = new Size(122, 55);
            btnInvestment.TabIndex = 11;
            btnInvestment.Text = "Investment";
            btnInvestment.UseVisualStyleBackColor = true;
            // 
            // btnEveryday
            // 
            btnEveryday.Location = new Point(14, 12);
            btnEveryday.Name = "btnEveryday";
            btnEveryday.Size = new Size(122, 56);
            btnEveryday.TabIndex = 10;
            btnEveryday.Text = "Everyday";
            btnEveryday.UseVisualStyleBackColor = true;
            // 
            // accountDetails
            // 
            accountDetails.Location = new Point(268, 285);
            accountDetails.Name = "accountDetails";
            accountDetails.Size = new Size(122, 24);
            accountDetails.TabIndex = 14;
            accountDetails.Text = "Account Details";
            accountDetails.UseVisualStyleBackColor = true;
            accountDetails.Click += accountDetails_Click;
            // 
            // withdrawMoney
            // 
            withdrawMoney.Location = new Point(618, 12);
            withdrawMoney.Name = "withdrawMoney";
            withdrawMoney.Size = new Size(122, 24);
            withdrawMoney.TabIndex = 15;
            withdrawMoney.Text = "Withdraw Money";
            withdrawMoney.UseVisualStyleBackColor = true;
            withdrawMoney.Click += withdrawMoney_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(577, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 214);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnViewAccount
            // 
            btnViewAccount.Location = new Point(618, 319);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new Size(122, 23);
            btnViewAccount.TabIndex = 17;
            btnViewAccount.Text = "View Account";
            btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(573, 357);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(207, 214);
            listBox2.TabIndex = 18;
            // 
            // accountInfo
            // 
            accountInfo.Location = new Point(161, 12);
            accountInfo.Name = "accountInfo";
            accountInfo.Size = new Size(345, 267);
            accountInfo.TabIndex = 13;
            accountInfo.Text = "";
            accountInfo.TextChanged += accountInfo_TextChanged;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(12, 309);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(122, 23);
            btnDeposit.TabIndex = 19;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(12, 357);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(207, 214);
            listBox3.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 585);
            Controls.Add(listBox3);
            Controls.Add(btnDeposit);
            Controls.Add(listBox2);
            Controls.Add(btnViewAccount);
            Controls.Add(listBox1);
            Controls.Add(withdrawMoney);
            Controls.Add(accountDetails);
            Controls.Add(accountInfo);
            Controls.Add(btnOmni);
            Controls.Add(btnInvestment);
            Controls.Add(btnEveryday);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnOmni;
        private Button btnInvestment;
        private Button btnEveryday;
        private Button accountDetails;
        private Button withdrawMoney;
        private ListBox listBox1;
        private Button btnViewAccount;
        private ListBox listBox2;
        private RichTextBox accountInfo;
        private Button btnDeposit;
        private ListBox listBox3;
    }
}