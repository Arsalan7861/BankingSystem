using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.DataAccessLayer.Concrete;
using Dapper;
using Npgsql;

namespace BankingSystem.PresentationLayer
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly IAccountService _accountService;
        private readonly string _connectionString;
        public Form(string connectionString)
        {
            _connectionString = connectionString;
            _accountService = new AccountManager(new AccountDal(_connectionString));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var accounts = _accountService.TGetAll();
            dataGridView1.DataSource = accounts;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var customerTc = txtCustomerTc.Text;
            var amount = Convert.ToDecimal(txtAmount.Text);
            _accountService.TdepositMoney(customerTc, amount);
            MessageBox.Show("Money deposited successfully");
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var customerTc = txtCustomerTc.Text;
            var amount = Convert.ToDecimal(txtAmount.Text);
            _accountService.TwithdrawMoney(customerTc, amount);
            MessageBox.Show("Money withdrawn successfully");
        }
    }
}
