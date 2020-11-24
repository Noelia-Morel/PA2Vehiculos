using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class VehiculosDAL
    {
        Contexto contexto;

        public int Agregar(VehiculoDTO vehiculoDTO)
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

        public List<VehiculoDTO> ObtenerVehiculos()
        {
            List<Vehiculos> listaVehiculos = new List<Vehiculos>();

            try
            {
                using (contexto = new Contexto())
                {
                    listaVehiculos = contexto.Vehiculos.ToList();
                }

                return ConvertirAListaDTO(listaVehiculos);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<VehiculoDTO> ConsultarVehiculos(string texto)
        {
            List<Vehiculos> listaVehiculos = new List<Vehiculos>();
            try
            {
                using (contexto = new Contexto())
                {
                    listaVehiculos = contexto.Vehiculos // con exp lambda busco en dos campos de la tabla el texto
                                    .Where(datos => contexto.Vehiculos.Any(x => datos.Marca.Contains(texto)) ||
                                    contexto.Vehiculos.Any(x => datos.Modelo.Contains(texto))).ToList();
                }

                return ConvertirAListaDTO(listaVehiculos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VehiculoDTO ConsultarVehiculo(int id)
        {
            Vehiculos vehiculo; 

            try
            {
                using (contexto = new Contexto())
                {
                    vehiculo = contexto.Vehiculos.Find(id);
                }

                return ConvertirADTO(vehiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static List<VehiculoDTO> ConvertirAListaDTO(List<Vehiculos> listaVehiculos)
        {
            List<VehiculoDTO> listavehiculoDTO = new List<VehiculoDTO>();

            foreach (var vehiculo in listaVehiculos)
            {
                VehiculoDTO vehiculoDTO = ConvertirADTO(vehiculo);

                listavehiculoDTO.Add(vehiculoDTO);
            }
            return listavehiculoDTO;
        }

        private static VehiculoDTO ConvertirADTO(Vehiculos vehiculo)
        {
            return new VehiculoDTO()
            {
                AnioFabricacion = vehiculo.AnioFabricacion,
                ClienteId = vehiculo.ClienteId.Value,
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
