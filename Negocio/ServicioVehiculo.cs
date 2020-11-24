using Datos;
using Datos.Entidades;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ServicioVehiculo
    {
        public static int AgregarVehiculo(ItemVehiculo vehiculo)
        {
            try
            {

                VehiculosDAL vehiculosDAL = new VehiculosDAL();
                VehiculoDTO vehiculoDTO = new VehiculoDTO() 
                {
                    AnioFabricacion = vehiculo.AnioFabricacion,
                    ClienteId = vehiculo.ClienteId,
                    Dominio = vehiculo.Dominio,
                    FechaIngreso = vehiculo.FechaIngreso,
                    FechaVenta = vehiculo.FechaVenta,
                    Id = vehiculo.Id,
                    Marca = vehiculo.Marca,
                    Modelo = vehiculo.Modelo,
                    NroMotor = vehiculo.NroMotor,
                    PrecioVenta = vehiculo.PrecioVenta,
                    ValuacionIngreso = vehiculo.ValuacionIngreso
                };
                return vehiculosDAL.Agregar(vehiculoDTO);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
