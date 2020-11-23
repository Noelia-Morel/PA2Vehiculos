using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VehiculosDAL
    {
        Contexto contexto;

        public int Agregar(VehiculoDTO vehiculoDTO )
        {
            try
            {
                Vehiculos vehiculo = new Vehiculos()
                {
                    AnioFabricacion = vehiculoDTO.AnioFabricacion,
                    ClienteId = vehiculoDTO.ClienteId,
                    Dominio = vehiculoDTO.Dominio,
                    FechaIngreso = vehiculoDTO.FechaIngreso,
                    FechaVenta = vehiculoDTO.FechaVenta,
                    Marca = vehiculoDTO.Marca,
                    Modelo = vehiculoDTO.Modelo,
                    NroMotor = vehiculoDTO.NroMotor,
                    PrecioVenta = vehiculoDTO.PrecioVenta,
                    ValuacionIngreso = vehiculoDTO.ValuacionIngreso

                };

                using (contexto = new Contexto())
                {
                    contexto.Vehiculos.Add(vehiculo);
                    contexto.SaveChanges();
                }

                return vehiculo.Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(VehiculoDTO vehiculoDTO)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    Vehiculos vehiculo = contexto.Vehiculos.Find(vehiculoDTO.Id);
                    vehiculo.AnioFabricacion = vehiculoDTO.AnioFabricacion;
                    vehiculo.ClienteId = vehiculoDTO.ClienteId;
                    vehiculo.Dominio = vehiculoDTO.Dominio;
                    vehiculo.FechaIngreso = vehiculoDTO.FechaIngreso;
                    vehiculo.FechaVenta = vehiculoDTO.FechaVenta;
                    vehiculo.Marca = vehiculoDTO.Marca;
                    vehiculo.Modelo = vehiculoDTO.Modelo;
                    vehiculo.NroMotor = vehiculoDTO.NroMotor;
                    vehiculo.PrecioVenta = vehiculoDTO.PrecioVenta;
                    vehiculo.ValuacionIngreso = vehiculoDTO.ValuacionIngreso;
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var vehiculo = contexto.Clientes.Find(id);
                    contexto.Clientes.Remove(vehiculo);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
