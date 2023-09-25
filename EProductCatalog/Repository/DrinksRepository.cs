using EProductCatalog.Context;
using EProductCatalog.Models;
using EProductCatalog.Models.Dto;
using EProductCatalog.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> Delete(int id)
        {
            Drinks? drink = await _appContext.Drinks.FirstOrDefaultAsync(x => x.Id == id && x.Status);
            if (drink == null) return false;
            drink.Status = false;
            await _appContext.SaveChangesAsync();
            return true;
        }

        public async Task<Pages<Drinks>> GetAll(int? offset, int? limit)
        {
            IQueryable<Drinks> query = _appContext.Drinks.Where(x => x.Status);
            List<Drinks> drinks = await query.OrderBy(x => x.Id).Skip(offset ?? 0).Take(limit ?? 10).ToListAsync();
            int totalItems = await query.CountAsync();
            return new Pages<Drinks>()
            {
                TotalItems = totalItems,
                Elements = drinks
            };
        }

        public async Task<Pages<Drinks>> GetAllBy(Expression<Func<Drinks, bool>> predicate, int? offset, int? limit)
        {
            IQueryable<Drinks> query = _appContext.Drinks.Where(predicate);
            List<Drinks> drinks = await query.OrderBy(x => x.Id).Skip(offset ?? 0).Take(limit ?? 0).ToListAsync();
            int totalItems = await query.CountAsync();
            return new Pages<Drinks>()
            {
                TotalItems = totalItems,
                Elements = drinks
            };
        }

        public async Task<Drinks?> GetOneBy(Expression<Func<Drinks, bool>> predicate)
        {
            Drinks? drink = await _appContext.Drinks.FirstOrDefaultAsync(predicate);
            return drink;
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
