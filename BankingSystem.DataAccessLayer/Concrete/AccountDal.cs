using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.DataAccessLayer.Repositories;
using BankingSystem.EntityLayer.Models;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Concrete
{
    public class AccountDal : GenericRepository<Account>, IAccountDal
    {
        public AccountDal(string connectionString) : base(connectionString)
        {
        }

        public void CreateBankAccount(string customerTc, string accountType, decimal balance, string iban, string currency)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                // Set the session staff tc
                using (var command = new NpgsqlCommand($"SET session staff.tc = '{SessionContext.StaffTc}'", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Create the bank account
                var query = "SELECT create_bank_account(@customerTc, @accountType, @balance, @iban, @currency)";
                connection.Execute(query, new { customerTc, accountType, balance, iban, currency });
            }
        }

        public void DeleteAccountByTcAndType(string customerTc, string accountType)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM account WHERE customertc = @customerTc AND accounttype = @accountType";
                connection.Execute(query, new { customerTc, accountType });
            }
        }

        public void DeleteBankAccount(int accountId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                // Set the session staff tc
                using(var command = new NpgsqlCommand($"SET session staff.tc = '{SessionContext.StaffTc}'", connection))
                {
                    command.ExecuteNonQuery();
                }

                // Delete the bank account
                var query = "SELECT delete_bank_account(@accountId)";
                connection.Execute(query, new { accountId });
            }
        }

        public void DepositMoney(string customerTc, decimal amount)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT deposit_money(@customerTc, @amount)";
                connection.Execute(query, new { customerTc, amount });
            }
        }

        public List<Account> GetAccountByTc(string customerTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM account WHERE customertc = @Customertc";
                return connection.Query<Account>(query, new { CustomerTc = customerTc }).ToList();
            }
        }

        public void SendMoney(string senderTc, string receiverTc, decimal amount)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT send_money(@senderTc, @receiverTc, @amount)";
                connection.Execute(query, new { senderTc, receiverTc, amount });
            }
        }

        public void WithdrawMoney(string customerTc, decimal amount)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT withdraw_money(@customerTc, @amount)";
                connection.Execute(query, new { customerTc, amount });
            }
        }
    }
}
