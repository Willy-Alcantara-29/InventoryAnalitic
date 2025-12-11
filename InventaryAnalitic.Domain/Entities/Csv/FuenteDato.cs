using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("fuentes")]
    public class FuenteDato
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("nombre")]
        public string Nombre { get; set; }
        
        [Column("tipo")]
        public string Tipo { get; set; }
    }
}