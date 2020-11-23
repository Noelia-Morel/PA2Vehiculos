using System;

namespace Datos.Entidades
{
    public class VehiculoDTO
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Dominio { get; set; }
        public DateTime AnioFabricacion { get; set; }
        public string NroMotor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public long ValuacionIngreso { get; set; }
        public DateTime FechaVenta { get; set; }
        public long PrecioVenta { get; set; }
        public Nullable<int> ClienteId { get; set; }
    }
}
