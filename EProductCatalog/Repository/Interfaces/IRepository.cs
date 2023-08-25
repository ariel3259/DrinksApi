using EProductCatalog.Models;
using EProductCatalog.Models.Dto;
using System.Linq.Expressions;

namespace EProductCatalog.Repository.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        public Task<Pages<T>> GetAll(int? offset, int? limit);
        public Task<T?> GetOneById(int id);
        public Task<Pages<T>> GetAllBy(Expression<Func<T, bool>> predicate,  int? offset, int? limit);
        public Task<T?> GetOneBy(Expression<Func<T, bool>> predicate);
    }
}
