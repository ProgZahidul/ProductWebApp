using ProductWebApp.DAL_Models;
using ProductWebApp.Models;
using ProductWebApp.Repository.IRepository;

namespace ProductWebApp.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ProductDBContext _db;
        public CategoryRepository(ProductDBContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.categories.Update(obj);
        }
    }
}
