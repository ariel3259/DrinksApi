using EProductCatalog.Models.Dto;
using EProductCatalog.Models.Dto.DrinkStatesDto;

namespace EProductCatalog.Services.Interfaces
{
    public interface IDrinkTypesService
    {
        public Task<Pages<DrinkTypesReponse>> GetAll(int? offset, int? limit);
    }
}
