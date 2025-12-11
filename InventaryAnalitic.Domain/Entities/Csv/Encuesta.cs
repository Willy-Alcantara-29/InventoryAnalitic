using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("encuestas")]
    public class Encuesta
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("cliente_id")]
        public int Cliente_id { get; set; }
        
        [Column("producto_id")]
        public int Producto_id { get; set; }
        
        [Column("fuente_id")]
        public int Fuente_id { get; set; }

        [Column("calificacion")]
        public int Calificacion { get; set; }
        
        [Column("comentario")]
        public string Comentario { get; set; }
    }
}