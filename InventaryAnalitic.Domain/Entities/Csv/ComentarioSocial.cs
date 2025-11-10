namespace InventaryAnalitic.Domain.Entities.Csv
{
    public class ComentarioSocial
    {
        public int Id { get; set; }
        public int Producto_id { get; set; }
        public string Plataforma { get; set; }
        public string Mensaje { get; set; }
        public int Likes { get; set; }
    }
}