using System.Data;
using Dapper;
using Npgsql;
using WebAppMVC.Models;


namespace WebAppMVC.Data;

public class CategoryRepository : ICategoryRepository
{
    string connectionString = null;
    public CategoryRepository(string conn)
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        connectionString = conn;
    }
    public List<Category> GetCategories()
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            return db.Query<Category>("SELECT * FROM category").ToList();
        }
    }
 
    public Category Get(int id)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            return db.Query<Category>("SELECT * FROM category WHERE id = @id", new { id }).FirstOrDefault();
        }
    }
 
    public void Create(Category category)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "INSERT INTO category (name, display_order) VALUES(@Name, @DisplayOrder)";
            db.Execute(sqlQuery, category);
        }
    }
 
    public void Update(Category category)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "UPDATE category SET name = @Name, display_order = @DisplayOrder WHERE id = @Id";
            db.Execute(sqlQuery, category);
        }
    }
 
    public void Delete(int id)
    {
        using (IDbConnection db = new NpgsqlConnection(connectionString))
        {
            var sqlQuery = "DELETE FROM category WHERE id = @id";
            db.Execute(sqlQuery, new { id });
        }
    }
}  
