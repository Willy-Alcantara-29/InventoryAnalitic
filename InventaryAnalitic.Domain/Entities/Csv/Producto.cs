using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("productos")]
    public class Producto
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("nombre")]
        public string Nombre { get; set; }
        
        [Column("categoria")]
        public string Categoria { get; set; }

        [Column("precio", TypeName = "decimal(8, 2)")]
        public decimal Precio { get; set; }
    }
}