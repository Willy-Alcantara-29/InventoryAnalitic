using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    // Keeping namespace as Csv to avoid breaking too many things instantly, but matching SQL schema
    [Table("clientes")]
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("nombre")]
        public string Nombre { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        [Column("ciudad")]
        public string Ciudad { get; set; }
    }
}