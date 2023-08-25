using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EProductCatalog.Models
{
    [Table("drink_types")]
    public class DrinkTypes: BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }

        public virtual List<Drinks>? Drinks { get; set; }
    }
}
