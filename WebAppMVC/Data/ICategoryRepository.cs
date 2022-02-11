using WebAppMVC.Models;

namespace WebAppMVC.Data;

public interface ICategoryRepository
{
    void Create(Category category);
    void Delete(int id);
    Category Get(int id);
    List<Category> GetCategories();
    void Update(Category category);
}