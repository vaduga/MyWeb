using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Npgsql;
using WebAppMVC.Models;

namespace WebAppMVC.Data;

public class CategoryRepository : ICategoryRepository
{
    string connectionString = null;
    public CategoryRepository(string conn)
    {
        connectionString = conn;
    }
    public List<Category> GetCategories()
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            return db.Query<Category>("SELECT * FROM \"Category\"").ToList();
        }
    }
 
    public Category Get(int id)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            return db.Query<Category>("SELECT * FROM \"Category\" WHERE \"Id\" = @id", new { id }).FirstOrDefault();
        }
    }
 
    public void Create(Category category)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "INSERT INTO \"Category\" (\"Name\", \"DisplayOrder\") VALUES(@Name, @DisplayOrder)";
            db.Execute(sqlQuery, category);
        }
    }
 
    public void Update(Category category)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "UPDATE \"Category\" SET \"Name\" = @Name, \"DisplayOrder\" = @DisplayOrder WHERE \"Id\" = @Id";
            db.Execute(sqlQuery, category);
        }
    }
 
    public void Delete(int id)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "DELETE FROM \"Category\" WHERE \"Id\" = @id";
            db.Execute(sqlQuery, new { id });
        }
    }
}  
