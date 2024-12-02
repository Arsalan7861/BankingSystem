using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.EntityLayer.Models;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly string _connectionString;

        public GenericRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public void Add(T entity)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = GenerateInsertQuery(entity);
                connection.Execute(query, entity);
            }
        }

        public void Delete(T entity)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = GenerateDeleteQuery(entity);
                connection.Execute(query, entity);
            }
        }

        public List<T> GetAll()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = $"SELECT * FROM \"{typeof(T).Name}\"";
                return connection.Query<T>(query).ToList();
            }
        }

        public T GetById(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = $"SELECT * FROM \"{typeof(T).Name}\" WHERE Id = @Id";
                return connection.QuerySingleOrDefault<T>(query, new { Id = id });
            }
        }

        public void Update(T entity)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = GenerateUpdateQuery(entity);
                connection.Execute(query, entity);
            }
        }

        // Placeholder methods for generating queries
        private static string GenerateInsertQuery(T entity)
        {
            var type = typeof(T);
            var tableName = $"\"{type.Name}\"";
            var properties = type.GetProperties();

            var columnNames = string.Join(", ", properties.Select(p => p.Name));
            var parameterNames = string.Join(", ", properties.Select(p => "@" + p.Name));

            var query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";
            return query;
        }

        private static string GenerateDeleteQuery(T entity)
        {
            var type = typeof(T);
            var tableName = $"\"{type.Name}\"";
            var keyProperty = type.GetProperties().FirstOrDefault(p => p.Name == "Id" || p.Name == $"{type.Name}Id");

            if (keyProperty == null)
            {
                throw new InvalidOperationException("No key property found.");
            }

            var query = $"DELETE FROM {tableName} WHERE {keyProperty.Name} = @{keyProperty.Name}";
            return query;
        }

        private static string GenerateUpdateQuery(T entity)
        {
            var type = typeof(T);
            var tableName = $"\"{type.Name}\"";
            var properties = type.GetProperties();

            var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
            var keyProperty = properties.FirstOrDefault(p => p.Name == "Id" || p.Name == $"{type.Name}Id");

            if (keyProperty == null)
            {
                throw new InvalidOperationException("No key property found.");
            }

            var query = $"UPDATE {tableName} SET {setClause} WHERE {keyProperty.Name} = @{keyProperty.Name}";
            return query;
        }
    }
}
