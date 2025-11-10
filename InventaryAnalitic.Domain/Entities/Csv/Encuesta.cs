namespace InventaryAnalitic.Domain.Entities.Csv
{
    public class Encuesta
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public int Producto_id { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }
    }
}