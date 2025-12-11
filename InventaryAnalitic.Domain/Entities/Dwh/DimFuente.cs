using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Dim_Fuente")]
    public class DimFuente
    {
        [Column("ID_Fuente")]
        public int ID_Fuente { get; set; }
        
        public string NombreFuente { get; set; }
        public string Canal { get; set; }
    }
}