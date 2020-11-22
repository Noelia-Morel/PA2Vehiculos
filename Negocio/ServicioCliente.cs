using Negocio.Entidades;
using Datos;
using Datos.Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public static class ServicioCliente
    {

        public static int AgregarCliente(ItemCliente cliente)
        {
            try
            {
                ClientesDAL clienteDAL = new ClientesDAL();
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Apellido = cliente.Apellido,
                    DNI = cliente.DNI,
                    Nombre = cliente.Nombre
                };

                return clienteDAL.Agregar(clienteDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ItemCliente> Consultar(string texto = null)
        {
            try
            {
                ClientesDAL clienteDAL = new ClientesDAL();
                List<ItemCliente> itemClienteList = new List<ItemCliente>();
                List<ClienteDTO> clienteDTOlist = new List<ClienteDTO>();

                if (string.IsNullOrEmpty(texto))
                {
                    clienteDTOlist = clienteDAL.BuscarClientes(texto);
                }
                else
                {
                    clienteDTOlist = clienteDAL.ObtenerClientes();
                }

                foreach (var cliente in clienteDTOlist)
                {
                    itemClienteList.Add(new ItemCliente() { 
                    Id = cliente.Id,
                    Apellido = cliente.Apellido,
                    DNI = cliente.DNI,
                    Nombre = cliente.Nombre
                    });
                }

                return itemClienteList;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
