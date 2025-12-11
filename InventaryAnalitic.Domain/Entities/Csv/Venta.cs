using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("ventas")]
    public class Venta
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("cliente_id")]
        public int Cliente_id { get; set; }
        
        [Column("producto_id")]
        public int Producto_id { get; set; }
        
        [Column("fuente_id")]
        public int Fuente_id { get; set; }

        [Column("empleado_id")]
        public int Empleado_id { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("total", TypeName = "decimal(8, 2)")]
        public decimal Total { get; set; }
        
        [Column("fecha")]
        public DateTime Fecha { get; set; }
    }
}