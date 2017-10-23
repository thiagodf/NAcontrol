using System.Collections.Generic;

namespace NAControl.Business.Services
{
    public interface ServiceBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
