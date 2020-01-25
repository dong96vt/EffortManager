using System.Collections.Generic;
namespace EffortManager.AccessDatabase.DAO
{
    public abstract class BaseDAO<T> where T : class
    {
        public abstract T Get(string ID);
        public abstract IEnumerable<T> GetAll();
        public abstract bool Insert(T obj);
        public abstract bool Update(T obj);
        public abstract bool Delete(string ID);
    }
}