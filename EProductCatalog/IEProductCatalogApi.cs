using EProductCatalog.Models.Dto.DrinkStatesDto;
using Refit;

namespace EProductCatalog
{
    public interface IEProductCatalogApi
    {
        [Get("/api/drinkTypes")]
        Task<DrinkTypesReponse> GetAll(int? offset, int? limit);
    }
}
