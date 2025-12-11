using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("comentarios")]
    public class ComentarioSocial
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("producto_id")]
        public int Producto_id { get; set; }
        
        [Column("fuente_id")]
        public int Fuente_id { get; set; }

        [Column("mensaje")]
        public string Mensaje { get; set; }
        
        [Column("likes")]
        public int Likes { get; set; }
    }
}