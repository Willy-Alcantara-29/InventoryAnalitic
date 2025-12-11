using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Dim_Sentimiento")]
    public class DimSentimiento
    {
        [Column("ID_Sentimiento")]
        public int ID_Sentimiento { get; set; }
        
        public string Clasificacion { get; set; }
    }
}