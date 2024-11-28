using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using Dapper;
using Npgsql;

namespace BankingSystem.PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly IAccountService _accountService;

        public Form1(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Example usage of the account service
            var accounts = _accountService.GetAll();
            // Do something with the accounts

            dataGridView1.DataSource = accounts;
        }
    }
}
