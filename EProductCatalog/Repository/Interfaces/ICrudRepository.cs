using EProductCatalog.Models;

namespace EProductCatalog.Repository.Interfaces
{
    public interface ICrudRepository<T>: IRepository<T> where T: BaseEntity
    {
        public Task<T?> Save(T entity);
        public Task<T?> Update(T entity);
        public Task<bool> Delete(int id);
    }
}
