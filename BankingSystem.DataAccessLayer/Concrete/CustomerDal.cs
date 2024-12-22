using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.DataAccessLayer.Repositories;
using BankingSystem.EntityLayer.Models;
using Npgsql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Concrete
{
    public class CustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public CustomerDal(string connectionString) : base(connectionString)
        {
        }

        public void CreateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL create_customer(@customerTc, @fname, @lname, @password, @phone, @address, @staffTc)";
                connection.Execute(query, new { customerTc, fname, lname, password, phone, address, staffTc });
            }
        }

        public void DeleteCustomer(string customerTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL delete_customer(@customerTc)";
                connection.Execute(query, new { customerTc });
            }
        }

        public Customer GetCustomerByTc(string customerTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM customer WHERE customertc = @customertc";
                return connection.QueryFirstOrDefault<Customer>(query, new { customerTc });
            }
        }

        public void UpdateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "CALL update_customer(@customerTc, @fname, @lname, @password, @phone, @address, @staffTc)";
                connection.Execute(query, new { customerTc, fname, lname, password, phone, address, staffTc });
            }
        }
    }
}
