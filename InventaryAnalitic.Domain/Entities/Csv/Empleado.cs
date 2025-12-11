using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Csv
{
    [Table("Empleados")]
    public class Empleado
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }
        
        [Column("pais")]
        public string Pais { get; set; }
    }
}
