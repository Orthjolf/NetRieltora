using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.DataProvider
{
    public class Repository<T> where T : Entity
    {
        protected readonly DbSet<T> DbSet;

        private readonly ApplicationDbContext _db;

        public Repository()
        {
            _db = ApplicationDbContext.Instance;
            DbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
            _db.SaveChanges();
        }

        public T Get(int id)
        {
            return DbSet.First(e => e.Id == id);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return DbSet.ToList().AsReadOnly();
        }
    }
}