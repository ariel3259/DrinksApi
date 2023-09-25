using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EProductCatalog.Models
{
    public abstract class BaseEntity<Dto, DtoUpdate>
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("updated_by")]
        public string UpdatedBy { get; set; }
        [Column("status")]
        public bool Status { get; set; }

        public abstract BaseEntity<Dto, DtoUpdate> fromDto(Dto dto);
        public abstract void modify(Dto dto);
    }

    public abstract class BaseEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("updated_by")]
        public string UpdatedBy { get; set; }
        [Column("status")]
        public bool Status { get; set; }
    }
}
