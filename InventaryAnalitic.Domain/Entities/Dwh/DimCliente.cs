namespace InventaryAnalitic.Domain.Entities.Dwh
{
    public class DimCliente
    {
        public int ID_Cliente { get; set; } // Clave subrogada
        public string ID_Cliente_Fuente { get; set; }
        public string NombreCliente { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string RangoEdad { get; set; }
        public string TipoCliente { get; set; }
    }
}