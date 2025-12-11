using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Fact_Opiniones")]
    public class FactOpiniones
    {
        [Column("ID_Opinion")]
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