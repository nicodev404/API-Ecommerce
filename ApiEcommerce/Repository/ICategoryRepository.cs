using System;

namespace ApiEcommerce.Repository;

public interface ICategoryRepository
{
    ICollection<Category> GetCategory();
    Category GetCategory(int Id);
    bool CategoryExists(int Id);
    bool CategoryExists(string Name);
    bool CreateCategory(Category category);
    bool UpdateCategory(Category category);
    bool DeleteCategory(Category category);
    bool Save();
}
