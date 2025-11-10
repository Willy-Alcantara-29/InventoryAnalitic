using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    public class Venta
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public int Producto_id { get; set; }
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}