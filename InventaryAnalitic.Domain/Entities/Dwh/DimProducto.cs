using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Dim_Producto")]
    public class DimProducto
    {
        [Column("ID_Producto")]
        public int ID_Producto { get; set; } // Clave subrogada
        
        [Column("SKU_Producto")]
        public string SKU_Producto { get; set; }
        
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string Marca { get; set; }
    }
}