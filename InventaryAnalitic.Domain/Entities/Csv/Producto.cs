using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
    }
}