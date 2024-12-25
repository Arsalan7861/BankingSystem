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
    public class StaffDal : GenericRepository<Staff>, IStaffDal
    {
        public StaffDal(string connectionString) : base(connectionString)
        {
        }

        public void CreateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL create_staff(@staffTc, @fname, @lname, @password, @position, @phone, @branchId, @address, @email)";
                connection.Execute(query, new { staffTc, fname, lname, password, position, phone, branchId, address, email });
            }
        }

        public void DeleteStaff(string staffTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL delete_staff(@staffTc)";
                connection.Execute(query, new { staffTc });
            }
        }

        public Staff GetManagerByTc(string managerTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM staff WHERE stafftc = @managerTc";
                return connection.QueryFirstOrDefault<Staff>(query, new { managerTc });
            }
        }

        public void UpdateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL update_staff(@staffTc, @fname, @lname, @password, @position, @phone, @branchId, @address, @email)";
                connection.Execute(query, new { staffTc, fname, lname, password, position, phone, branchId, address, email });
            }
        }
    }
}
