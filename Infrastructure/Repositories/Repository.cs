using Application.Helpers;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> DbSet;
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }
        public T GetById(object id)
        {
            return DbSet.Find(id);
        }
        public void Insert(T obj)
        {
            DbSet.Add(obj);
        }
        public void Update(T obj)
        {
            DbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = DbSet.Find(id);
            DbSet.Remove(existing);
        }

        public List<T> SqlQuery(string sql, params object[] parameters)
        {
            return DbSet.FromSqlRaw(sql, parameters).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
