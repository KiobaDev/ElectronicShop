using System.Collections.Generic;

namespace Application.Helpers
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        public List<T> SqlQuery(string sql, params object[] parameters);
        void Save();
    }
}
