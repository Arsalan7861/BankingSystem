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

            LoadData();
        }

        private void LoadData()
        {
            lblInformationTc.Text = _customerTc;
            // show account transactions in data grid view
            var transaction = _transactionService.TGetAll().Where(x => x.Transactionfromtc == _customerTc || x.Transactiontotc == _customerTc).ToList();
            dOverViewTransac.DataSource = transaction;
            dOverViewTransac.ClearSelection();
            dTransaction.DataSource = transaction;
            dTransaction.ClearSelection();

            // show accounts in data grid view
            dataSetAccount.DataSource = _accountService.TGetAccountByTc(_customerTc);
            dataSetAccount.ClearSelection();

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

            // if the customer does not have an account, show "No Account"
            if (accounts.All(x => x.Accounttype != "Demand Deposit"))
            {
                lDemandMoney.Text = "No Account";
                lDemandIbanNo.Text = "No Account";
            }

            if (accounts.All(x => x.Accounttype != "Credit"))
            {
                lCreditMoney.Text = "No Account";
                lCreditIbanNo.Text = "No Account";
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
            pSeeAllTransactions.Hide();
            panelSendMoney.Hide();
            pTransactions.Show();
        }

        private void lGoToTransactions_Click(object sender, EventArgs e)
        {
            pTransactions.Show();
            pSupport.Hide();
        }

        private void bCreateCredit_Click(object sender, EventArgs e)
        {
            if (tCreditInitialBalance.Text == "" || tCreditPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var customer = _customerService.TGetCustomerByTc(_customerTc);
            if (tCreditPassword.Text != customer.Customerpassword)
            {
                MessageBox.Show("Password is Incorrect!");
                return;
            }

            var accounts = _accountService.TGetAccountByTc(_customerTc);
            foreach (var account in accounts)
            {
                if (account.Accounttype == "Credit")
                {
                    MessageBox.Show("You already have a credit account.");
                    tCreditInitialBalance.Text = "";
                    tCreditPassword.Text = "";
                    return;
                }
            }

            var accountType = "Credit";
            decimal initialBalance = decimal.Parse(tCreditInitialBalance.Text);
            var currency = "TRY";
            var iban = GenerateUniqueIban();
            SessionContext.StaffTc = customer.Stafftc;// Set the session staff tc
            _accountService.TcreateBankAccount(_customerTc, accountType, initialBalance, iban, currency);
            MessageBox.Show("Credit Account Created Successfully");
            tCreditInitialBalance.Text = "";
            tCreditPassword.Text = "";

            LoadData();
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
            if (tDemandInitialBalance.Text == "" || tDemandPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var customer = _customerService.TGetCustomerByTc(_customerTc);
            if (tDemandPassword.Text != customer.Customerpassword)
            {
                MessageBox.Show("Password is Incorrect!");
                return;
            }

            var accounts = _accountService.TGetAccountByTc(_customerTc);
            foreach (var account in accounts)
            {
                if (account.Accounttype == "Demand Deposit")
                {
                    MessageBox.Show("You already have a demand deposit account.");
                    tDemandInitialBalance.Text = "";
                    tDemandPassword.Text = "";
                    return;
                }
            }

            var accountType = "Demand Deposit";
            decimal initialBalance = decimal.Parse(tDemandInitialBalance.Text);
            var currency = "TRY";
            SessionContext.StaffTc = customer.Stafftc;// Set the session staff tc
            var iban = GenerateUniqueIban();
            _accountService.TcreateBankAccount(_customerTc, accountType, initialBalance, iban, currency);
            MessageBox.Show("Demand Deposit Account Created Successfully");
            tDemandInitialBalance.Text = "";
            tDemandPassword.Text = "";

            LoadData();
        }

        private void bCloseAcc_Click(object sender, EventArgs e)
        {
            if (cmbAccCloseReqAccountType.SelectedItem == null || tAccCloseReqPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var customer = _customerService.TGetCustomerByTc(_customerTc);
            if (tAccCloseReqPass.Text != customer.Customerpassword)
            {
                MessageBox.Show("Password is Incorrect!");
                return;
            }

            SessionContext.StaffTc = customer.Stafftc;// Set the session staff tc

            if (cmbAccCloseReqAccountType.SelectedItem.ToString() == "Credit")
            {
                _accountService.TDeleteAccountByTcAndType(_customerTc, "Credit");
            }
            else if (cmbAccCloseReqAccountType.SelectedItem.ToString() == "Demand Deposit")
            {
                _accountService.TDeleteAccountByTcAndType(_customerTc, "Demand Deposit");
            }
            MessageBox.Show("Account Closed Successfully");
            tAccCloseReqPass.Text = "";
            cmbAccCloseReqAccountType.SelectedItem = null;
            LoadData();
        }

        private void bChaPass_Click(object sender, EventArgs e)
        {
            if (tOldPass.Text == "" || tNewPass.Text == "" || tNewPassAgain.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

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
            LoadData();
        }

        private void bInformationButton_Click(object sender, EventArgs e)
        {
            if (tInformationName.Text == "" || tInformationSurname.Text == "" || tInformationAddress.Text == "" || tInformationPhone.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var customer = _customerService.TGetCustomerByTc(_customerTc);
            customer.Customerfname = tInformationName.Text;
            customer.Customerlname = tInformationSurname.Text;
            customer.Customeraddress = tInformationAddress.Text;
            customer.Customerphone = tInformationPhone.Text;
            if (customer.Customerpassword == tInformationPass.Text)
            {
                _customerService.TUpdateCustomer(customer.Customertc, customer.Customerfname, customer.Customerlname, customer.Customerpassword, customer.Customerphone, customer.Customeraddress, customer.Stafftc);
                MessageBox.Show("Information Updated Successfully.");
                tInformationPass.Text = "";
            }
            else
            {
                MessageBox.Show("Password is Incorrect!");
            }
            LoadData();
        }

        private void bSeeAllTransactions_Click(object sender, EventArgs e)
        {
            panelSendMoney.Hide();
            pSeeAllTransactions.Show();
        }

        private void bSendMoney_Click(object sender, EventArgs e)
        {
            pSeeAllTransactions.Hide();
            panelSendMoney.Show();
        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            if (tReciverIban.Text == "" || tSendAmount.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var recipientIban = tReciverIban.Text;
            var amount = decimal.Parse(tSendAmount.Text);

            // Check if the recipient exists
            var customers = _customerService.TGetAll();
            if (customers.All(x => x.Customertc != recipientIban))
            {
                MessageBox.Show("There is no customer with this IBAN!");
                return;
            }

            // Check if the sender has a demand deposit account
            var accounts = _accountService.TGetAccountByTc(_customerTc);
            if (accounts.All(x => x.Accounttype != "Demand Deposit"))
            {
                MessageBox.Show("You do not have a demand deposit account.");
                return;
            }

            _accountService.TsendMoney(_customerTc, recipientIban, amount);
            MessageBox.Show("Money Sent Successfully.");
            tReciverIban.Text = "";
            tSendAmount.Text = "";

            LoadData();
        }
    }
}
