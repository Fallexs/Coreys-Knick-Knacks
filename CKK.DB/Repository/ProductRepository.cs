using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Repository {
    public class ProductRepository : IProductRepository {
        private readonly IConnectionFactory _connectionFactory;
        public ProductRepository(IConnectionFactory Conn) {
            _connectionFactory = Conn;
        }
        public int Add(Product entity) {
            string sql = "INSERT INTO Products (Id, Name, Price, Quantity) VALUES (@Id, @Name, @Price, @Quantity)";
            using( var connection = _connectionFactory.GetConnection ) {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }


        public int Delete(Product entity)
        {
            string sql = "DELETE FROM Products WHERE Id = @Id";
            using (IDbConnection connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        public List<Product> GetAll() {
            string sql = "SELECT * FROM Products";
            using( var connection = _connectionFactory.GetConnection ) {
                connection.Open();
                var result = connection.Query<Product>(sql).ToList();
                return result;
            }
        }

        public Product GetById(int id) {
            string sql = "SELECT * FROM Products WHERE Id = @Id";
            using( var connection = _connectionFactory.GetConnection ) {
                connection.Open();
                var result = connection.QuerySingleOrDefault<Product>(sql, new { Id = id });
                return result;
            }
        }

        public List<Product> GetByName(string name) {
            string sql = "SELECT * FROM Products WHERE Name = @Name";
            using( var connection = _connectionFactory.GetConnection ) {
                connection.Open();
                var result = connection.Query<Product>(sql, new { Name = name }).ToList();
                return result;
            }
        }

        public int Update(Product entity) {
            string sql = "UPDATE Products SET Price = @Price, Quantity = @Quantity, Name = @Name WHERE Id = @Id";
            using( var connection = _connectionFactory.GetConnection ) {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }
    }
}
