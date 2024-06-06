using ProductWebApp.Models;

namespace ProductWebApp.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
