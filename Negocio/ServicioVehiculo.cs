using Datos;
using Datos.Entidades;
using Negocio.Entidades;
using System;
using System.Collections.Generic;

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

        public static void Actualizar(ItemVehiculo vehiculo)
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

                vehiculosDAL.Actualizar(vehiculoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                VehiculosDAL vehiculosDAL = new VehiculosDAL();
                vehiculosDAL.Eliminar(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static ItemVehiculo Obtener(int id)
        {
            try
            {
                VehiculosDAL vehiculosDAL = new VehiculosDAL();
                VehiculoDTO vehiculoDTO = vehiculosDAL.ConsultarVehiculo(id);
                return ConvertirAItem(vehiculoDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ItemVehiculo> Consultar(string texto = null)
        {
            try
            {
                VehiculosDAL vehiculosDAL = new VehiculosDAL();
                List<ItemVehiculo> itemVehiculoList = new List<ItemVehiculo>();
                List<VehiculoDTO> vehiculoDTOList = new List<VehiculoDTO>();

                if (string.IsNullOrEmpty(texto))
                {
                    vehiculoDTOList = vehiculosDAL.ObtenerVehiculos();
                }
                else
                {
                    vehiculoDTOList = vehiculosDAL.ConsultarVehiculos(texto);
                }

                return ConvertirAItem(vehiculoDTOList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private static List<ItemVehiculo> ConvertirAItem(List<VehiculoDTO> vehiculos)
        {
            List<ItemVehiculo> lista = new List<ItemVehiculo>();

            foreach (var vehiculo in vehiculos)
            {
                lista.Add(ConvertirAItem(vehiculo));
            }

            return lista;
        }

        private static ItemVehiculo ConvertirAItem(VehiculoDTO vehiculo)
        {
            return new ItemVehiculo()
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
        }
    }
}
