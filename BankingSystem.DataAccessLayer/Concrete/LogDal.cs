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
    public class LogDal: GenericRepository<Log>, ILogDal
    {
        public LogDal(string connectionString) : base(connectionString)
        {
        }

        public List<Log> SearchLog(string tc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM log WHERE stafftc LIKE @tc OR customertc LIKE @Tc";
                var result = connection.Query<Log>(query, new { Tc = $"%{tc}%" });
                return result.ToList();
            }
        }
    }
}
