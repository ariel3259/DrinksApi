using EProductCatalog.Context;
using EProductCatalog.Models;
using EProductCatalog.Models.Dto;
using EProductCatalog.Repository.Interfaces;
using System.Linq.Expressions;

namespace EProductCatalog.Repository
{
    public class DrinksRepository: ICrudRepository<Drinks>
    {
        private readonly ApplicationContext _appContext;
        public DrinksRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pages<Drinks>> GetAll(int? offset, int? limit)
        {
            throw new NotImplementedException();
        }

        public Task<Pages<Drinks>> GetAllBy(Expression<Func<Drinks, bool>> predicate, int? offset, int? limit)
        {
            throw new NotImplementedException();
        }

        public Task<Drinks?> GetOneBy(Expression<Func<Drinks, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Drinks?> GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Drinks?> Save(Drinks entity)
        {
            throw new NotImplementedException();
        }

        public Task<Drinks?> Update(Drinks entity)
        {
            throw new NotImplementedException();
        }
    }
}
