using EProductCatalog.Models;
using EProductCatalog.Models.Dto;
using EProductCatalog.Models.Dto.DrinkStatesDto;
using EProductCatalog.Repository.Interfaces;
using EProductCatalog.Services.Interfaces;

namespace EProductCatalog.Services
{
    public class DrinkTypesService : IDrinkTypesService
    {
        private readonly IRepository<DrinkTypes> _drinkTypesRepository;
        public DrinkTypesService(IRepository<DrinkTypes> drinkTypesRepository)
        {
            _drinkTypesRepository = drinkTypesRepository;
        }

        public async Task<Pages<DrinkTypesReponse>> GetAll(int? offset, int? limit)
        {
            Pages<DrinkTypes> page = await _drinkTypesRepository.GetAll(offset, limit);
            List<DrinkTypesReponse> content = new();
            foreach (DrinkTypes drinkType in page.Elements)
            {
                content.Add(new DrinkTypesReponse(drinkType));
            }
            return new Pages<DrinkTypesReponse>()
            {
                Elements = content,
                TotalItems = page.TotalItems
            };
        }
    }
}
