using System.ComponentModel.DataAnnotations.Schema;

namespace EProductCatalog.Models
{
    [Table("drinks")]
    public class Drinks: BaseEntity
    {
        [Column("price")]
        public double Price { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("drink_type_id")]
        public int DrinkTypeId { get; set; }

        public virtual DrinkTypes? DrinkType { get; set; }
    }
}
