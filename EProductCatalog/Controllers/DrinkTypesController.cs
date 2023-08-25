using EProductCatalog.Models.Dto;
using EProductCatalog.Models.Dto.DrinkStatesDto;
using EProductCatalog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EProductCatalog.Controllers
{
    [ApiController]
    [Route("/api/drinkTypes")]
    public class DrinkTypesController: ControllerBase
    {
        private readonly IDrinkTypesService _service;
        public DrinkTypesController(IDrinkTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery(Name="offset")] int? offset, [FromQuery(Name="limit")] int? limit) 
        {
            Pages<DrinkTypesReponse> page = await _service.GetAll(offset, limit);
            Response.Headers.Add("x-total-count", page.TotalItems.ToString());
            return Ok(page.Elements);
        }
    }
}
