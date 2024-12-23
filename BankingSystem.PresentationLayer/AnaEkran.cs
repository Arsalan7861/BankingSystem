using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.DataAccessLayer.Concrete;
using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaprojesiform
{
    public partial class AnaEkran : Form
    {
        private readonly string _connectionString;
        private readonly ITransactionService _transactionService;
        private readonly IAccountService _accountService;
        private readonly string _customerTc;
        private readonly ICustomerService _customerService;
        public AnaEkran(string connectionString, string customerTc)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.FormClosing += AnaEkran_FormClosing; // Add the event handler to the form closing event
            _transactionService = new TransactionManager(new TransactionDal(connectionString));
            _accountService = new AccountManager(new AccountDal(connectionString));
            _customerTc = customerTc;
            _customerService = new CustomerManager(new CustomerDal(connectionString));
        }

        private void AnaEkran_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application when the form is closed
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            //Uygulamayı tam ekran başlatır
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;

            pOverview_Main.Show();
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pSupport.Hide();
            pTransactions.Hide();

            // show account transactions in data grid view
            var transaction = _transactionService.TGetAll();
            dOverViewTransac.DataSource = transaction;
            dTransaction.DataSource = transaction;

            // show accounts in data grid view
            dataSetAccount.DataSource = _accountService.TGetAll();

            // show account's amount and iban number according to account type
            var accounts = _accountService.TGetAccountByTc(_customerTc);
            foreach (var account in accounts)
            {
                if (account.Accounttype == "Demand Deposit")
                {
                    lDemandMoney.Text = $"{account.Accountbalance.ToString()} TL";
                    lDemandIbanNo.Text = account.Accountiban;
                }
                else if (account.Accounttype == "Credit")
                {
                    lCreditMoney.Text = $"{account.Accountbalance.ToString()} TL";
                    lCreditIbanNo.Text = account.Accountiban;
                }
            }

            // show customer information
            var customer = _customerService.TGetCustomerByTc(_customerTc);
            tInformationName.Text = customer.Customerfname;
            tInformationSurname.Text = customer.Customerlname;
            tInformationAddress.Text = customer.Customeraddress;
            tInformationPhone.Text = customer.Customerphone;

            lblWelcome.Text = $"Welcome to Bankacılık! {customer.Customerfname} {customer.Customerlname}, how can we assist you today?";
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            CreateAccount_Form form1 = new CreateAccount_Form(_connectionString);
            form1.Show();
            this.Hide();
        }

        private void bOverView_Click(object sender, EventArgs e)
        {
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pOverview_Main.Show();
            pTransactions.Hide();
            pSupport.Hide();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            pOverview_Main.Hide();
            pSettings.Hide();
            pDemand.Hide();
            pCredit.Hide();
            pCreateAccount_Main.Show();
            pSupport.Hide();
            pTransactions.Hide();
        }

        private void bDemand_Click(object sender, EventArgs e)
        {
            pCredit.Hide();
            pDemand.Show();
        }

        private void bCredit_Click(object sender, EventArgs e)
        {
            pDemand.Hide();
            pCredit.Show();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            pSettings.Show();
            pOverview_Main.Hide();
            pCreateAccount_Main.Hide();
            pInformation.Hide();
            pChangePass.Hide();
            pSeeAccount.Hide();
            pCloseAccReq.Hide();
            pSupport.Hide();
            pTransactions.Hide();
        }



        private void bInformation_Click(object sender, EventArgs e)
        {
            pChangePass.Hide();
            pCloseAccReq.Hide();
            pSeeAccount.Hide();

            pInformation.Show();
        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            pInformation.Hide();
            pCloseAccReq.Hide();
            pSeeAccount.Hide();

            pChangePass.Show();
        }

        private void bAccCloseReq_Click(object sender, EventArgs e)
        {
            pInformation.Hide();
            pChangePass.Hide();
            pSeeAccount.Hide();

            pCloseAccReq.Show();
        }

        private void bAccounts_Click(object sender, EventArgs e)
        {
            pSeeAccount.Show();

            pCloseAccReq.Hide();
            pChangePass.Hide();
            pInformation.Hide();


        }

        private void bSupport_Click(object sender, EventArgs e)
        {
            pSupport.Show();
            pSettings.Hide();
            pCreateAccount_Main.Hide();
            pOverview_Main.Hide();
            pTransactions.Hide();
        }

        private void lGoToChangePass_Click(object sender, EventArgs e)
        {
            pSupport.Hide();
            pSettings.Show();
            pChangePass.Show();
            pInformation.Hide();
        }

        private void lGoToInformations_Click(object sender, EventArgs e)
        {
            pSupport.Hide();
            pSettings.Show();
            pChangePass.Hide();
            pInformation.Show();
        }

        private void bTransaction_Click(object sender, EventArgs e)
        {
            pOverview_Main.Hide();
            pCreateAccount_Main.Hide();
            pSettings.Hide();
            pSupport.Hide();
            pTransactions.Show();
        }

        private void lGoToTransactions_Click(object sender, EventArgs e)
        {
            pTransactions.Show();
        }

        private void bCreateCredit_Click(object sender, EventArgs e)
        {
            var tc = tCreditTC.Text;
            var accountType = "Credit";
            decimal initialBalance = 0.0M;
            var currency = "TRY";
            var iban = GenerateUniqueIban();

            _accountService.TcreateBankAccount(tc, accountType, initialBalance, iban, currency);
            MessageBox.Show("Credit Account Created Successfully");
        }

        private string GenerateUniqueIban()
        {
            var countryCode = "TR";
            var bankCode = "00061"; // Example bank code
            var branchCode = "00000"; // Example branch code
            var uniquePart = GenerateUniqueDigits(14); // Generate a 16-digit unique number

            return $"{countryCode}{bankCode}{branchCode}{uniquePart}";
        }

        private string GenerateUniqueDigits(int length)
        {
            var random = new Random();
            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(random.Next(0, 10)); // Append a random digit (0-9)
            }
            return result.ToString();
        }

        private void bCreateDemand_Click(object sender, EventArgs e)
        {
            var tc = tDemandTC.Text;
            var accountType = "Demand Deposit";
            decimal initialBalance = 0.0M;
            var currency = "TRY";
            SessionContext.StaffTc = "3452";
            var iban = GenerateUniqueIban();
            _accountService.TcreateBankAccount(tc, accountType, initialBalance, iban, currency);
            MessageBox.Show("Demand Deposit Account Created Successfully");
        }

        private void bCloseAcc_Click(object sender, EventArgs e)
        {
            if (cmbAccCloseReqAccountType.SelectedItem.ToString() == "Credit")
            {
                _accountService.TDeleteAccountByTcAndType(tAccCloseReqTC.Text, "Credit");
            }
            else if (cmbAccCloseReqAccountType.SelectedItem.ToString() == "Demand Deposit")
            {
                _accountService.TDeleteAccountByTcAndType(tAccCloseReqTC.Text, "Demand Deposit");
            }
            MessageBox.Show("Account Closed Successfully");
        }

        private void bChaPass_Click(object sender, EventArgs e)
        {
            var customer = _customerService.TGetCustomerByTc(_customerTc);
            if (tNewPass.Text != tNewPassAgain.Text && tNewPass.Text == "")
            {
                MessageBox.Show("New Passwords do not match!");
                return;
            }

            if (customer.Customerpassword == tOldPass.Text)
            {
                customer.Customerpassword = tNewPass.Text;
                _customerService.TUpdateCustomer(customer.Customertc, customer.Customerfname, customer.Customerlname, customer.Customerpassword, customer.Customerphone, customer.Customeraddress, customer.Stafftc);
                MessageBox.Show("Password Changed Successfully.");
            }
            else
            {
                MessageBox.Show("Old Password is Incorrect!");
            }
        }

        private void bInformationButton_Click(object sender, EventArgs e)
        {
            var customer = _customerService.TGetCustomerByTc(_customerTc);
            customer.Customerfname = tInformationName.Text;
            customer.Customerlname = tInformationSurname.Text;
            customer.Customeraddress = tInformationAddress.Text;
            customer.Customerphone = tInformationPhone.Text;
            if (customer.Customerpassword == tInformationPass.Text)
            {
                _customerService.TUpdateCustomer(customer.Customertc, customer.Customerfname, customer.Customerlname, customer.Customerpassword, customer.Customerphone, customer.Customeraddress, customer.Stafftc);
                MessageBox.Show("Information Updated Successfully.");
            }
            else
            {
                MessageBox.Show("Password is Incorrect!");
            }
        }
    }
}
