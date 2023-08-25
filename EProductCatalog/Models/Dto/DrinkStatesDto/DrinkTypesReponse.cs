namespace EProductCatalog.Models.Dto.DrinkStatesDto
{
    public class DrinkTypesReponse
    {
        public int DrinkTypesId { get; set; }
        public string Description { get; set; }

        public DrinkTypesReponse(DrinkTypes drinkState)
        {
            DrinkTypesId = drinkState.Id;
            Description = drinkState.Description;
        }
    }
}
