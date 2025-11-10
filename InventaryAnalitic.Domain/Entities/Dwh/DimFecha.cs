namespace InventaryAnalitic.Domain.Entities.Dwh
{
    public class DimFecha
    {
        public int ID_Fecha { get; set; } // YYYYMMDD
        public DateTime FechaCompleta { get; set; }
        public int Anio { get; set; }
        public int Trimestre { get; set; }
        public int Mes { get; set; }
        public string NombreMes { get; set; }
        public int DiaDelMes { get; set; }
        public int DiaDeLaSemana { get; set; }
        public string NombreDia { get; set; }
    }
}