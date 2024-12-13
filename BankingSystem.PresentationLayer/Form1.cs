using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.DataAccessLayer.Concrete;
using Dapper;
using Npgsql;

namespace BankingSystem.PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly IAccountService _accountService;
        private readonly string _connectionString;
        public Form1(string connectionString)
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
    }
}
