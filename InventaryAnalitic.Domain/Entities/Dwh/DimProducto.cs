namespace InventaryAnalitic.Domain.Entities.Dwh
{
    public class DimProducto
    {
        public int ID_Producto { get; set; } // Clave subrogada
        public string SKU_Producto { get; set; }
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string Marca { get; set; }
    }
}