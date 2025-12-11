using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Dim_Cliente")]
    public class DimCliente
    {
        [Column("ID_Cliente")]
        public int ID_Cliente { get; set; } // Clave subrogada
        
        [Column("ID_Cliente_Fuente")]
        public string ID_Cliente_Fuente { get; set; }
        
        public string NombreCliente { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string RangoEdad { get; set; }
        public string TipoCliente { get; set; }
    }
}