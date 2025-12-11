using System.ComponentModel.DataAnnotations.Schema;

namespace InventaryAnalitic.Domain.Entities.Dwh
{
    [Table("Dim_Empleado")]
    public class DimEmpleado
    {
        [Column("ID_Empleado")]
        public int ID_Empleado { get; set; } // Clave subrogada

        [Column("ID_Empleado_Fuente")]
        public string ID_Empleado_Fuente { get; set; }

        public string NombreEmpleado { get; set; }
        public string Titulo { get; set; }
        public string Pais { get; set; }
    }
}
