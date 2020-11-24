using System;

namespace Negocio.Entidades
{
    public class ItemVehiculo
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
        public int ClienteId { get; set; }
    }
}
