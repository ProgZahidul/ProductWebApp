using ProductWebApp.DAL_Models;
using ProductWebApp.Repository.IRepository;

namespace ProductWebApp.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductDBContext _db;
        public ICategoryRepository Category { get; private set; }
       
        public UnitOfWork(ProductDBContext db)
        {
            _db = db;
           
            Category = new CategoryRepository(_db);
           
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
