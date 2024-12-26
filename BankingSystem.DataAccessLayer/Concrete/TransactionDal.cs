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
    public class TransactionDal : GenericRepository<Transaction>, ITransactionDal
    {
        public TransactionDal(string connectionString) : base(connectionString)
        {
        }

        public List<Transaction> SearchTransaction(string customerTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var query = "SELECT * FROM transaction WHERE transactionfromtc LIKE @CustomerTc OR transactiontotc LIKE @CustomerTc";
                return connection.Query<Transaction>(query, new { CustomerTc = $"%{customerTc}%" }).ToList();
            }
        }
    }
}
