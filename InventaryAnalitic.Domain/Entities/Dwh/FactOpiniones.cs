namespace InventaryAnalitic.Domain.Entities.Dwh
{
    public class FactOpiniones
    {
        public int ID_Opinion { get; set; }
        public int ID_Fecha { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Fuente { get; set; }
        public int ID_Sentimiento { get; set; }
        public int? Calificacion { get; set; }
        public int Conteo { get; set; }
        public string TextoComentario { get; set; }
    }
}