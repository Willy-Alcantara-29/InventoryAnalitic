using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Fact_Ventas")]
    public class FactVentas
    {
        [Column("ID_Venta")]
        public int ID_Venta { get; set; } // PK
        
        public int ID_Cliente { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Fecha { get; set; }
        public int ID_Fuente { get; set; }
        public int ID_Empleado { get; set; }
        public int Cantidad { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
    }
}
