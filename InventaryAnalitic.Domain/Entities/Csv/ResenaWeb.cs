using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("resenas")]
    public class ResenaWeb
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("producto_id")]
        public int Producto_id { get; set; }
        
        [Column("fuente_id")]
        public int Fuente_id { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("contenido")]
        public string Contenido { get; set; }
        
        [Column("puntuacion", TypeName = "decimal(2, 1)")]
        public decimal Puntuacion { get; set; }
    }
}