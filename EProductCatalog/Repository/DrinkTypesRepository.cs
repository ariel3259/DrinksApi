using EProductCatalog.Context;
using EProductCatalog.Models;
using EProductCatalog.Models.Dto;
using EProductCatalog.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EProductCatalog.Repository
{
    public class DrinkTypesRepository : IRepository<DrinkTypes>
    {
        private readonly ApplicationContext _appContext;

        public DrinkTypesRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Pages<DrinkTypes>> GetAll(int? offset, int? limit)
        {
            IQueryable<DrinkTypes> query = _appContext.DrinkTypes.Where(x => x.Status);
            List<DrinkTypes> drinkTypes = await query.OrderBy(x => x.Id).Skip(offset ?? 0).Take(limit ?? 10).ToListAsync();
            int totalItems = await query.CountAsync();
            return new Pages<DrinkTypes>()
            {
                TotalItems = totalItems,
                Elements = drinkTypes
            };
        }

        public async Task<Pages<DrinkTypes>> GetAllBy(Expression<Func<DrinkTypes, bool>> predicate, int? offset, int? limit)
        {
            IQueryable<DrinkTypes> query = _appContext.DrinkTypes.Where(predicate);
            List<DrinkTypes> drinkTypes = await query.OrderBy(x => x.Id).Skip(offset ?? 0).Take(limit ?? 10).ToListAsync();
            int totalItems = await query.CountAsync();
            return new Pages<DrinkTypes>()
            {
                TotalItems = totalItems,
                Elements = drinkTypes
            };
        }

        public async Task<DrinkTypes?> GetOneBy(Expression<Func<DrinkTypes, bool>> predicate)
        {
            return await _appContext.DrinkTypes.FirstOrDefaultAsync(predicate);
        }

        public async Task<DrinkTypes?> GetOneById(int id)
        {
            return await _appContext.DrinkTypes.FirstOrDefaultAsync(x => x.Id == id && x.Status);
        }
    }
}
