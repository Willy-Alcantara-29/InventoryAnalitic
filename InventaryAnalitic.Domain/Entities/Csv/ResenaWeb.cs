using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    public class ResenaWeb
    {
        public int Id { get; set; }
        public int Producto_id { get; set; }
        public string Sitio { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }

        [Column(TypeName = "decimal(3, 1)")]
        public decimal Puntuacion { get; set; }
    }
}