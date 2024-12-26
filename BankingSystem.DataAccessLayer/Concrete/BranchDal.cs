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
    public class BranchDal : GenericRepository<Branch>, IBranchDal
    {
        public BranchDal(string connectionString) : base(connectionString)
        {
        }
        public void CreateBranch(string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT create_branch(@branchCity, @branchStreet, @branchPostCode, @branchName)";
                connection.Execute(query, new { branchCity, branchStreet, branchPostCode, branchName });
            }
        }

        public void UpdateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT update_branch(@branchId, @branchCity, @branchStreet, @branchPostCode, @branchName)";
                connection.Execute(query, new { branchId, branchCity, branchStreet, branchPostCode, branchName });
            }
        }

        public void DeleteBranch(int branchId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT delete_branch(@branchId)";
                connection.Execute(query, new { branchId });
            }
        }

        public List<Branch> SearchBranch(string branchName)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var query = "SELECT * FROM branch WHERE branchname LIKE @BranchName";
                return connection.Query<Branch>(query, new { BranchName = $"%{branchName}%" }).ToList();
            }
        }
    }
}
