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

        public void depositMoney(string customerTc, decimal amount)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT deposit_money(@customerTc, @amount)";
                connection.Execute(query, new {customerTc, amount});
            }
        }

        public void withdrawMoney(string customerTc, decimal amount)
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
