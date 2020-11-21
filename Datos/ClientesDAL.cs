using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClientesDAL
    {
        Contexto contexto;

        public int Agregar(ClienteDTO clienteDTO)
        {
            try
            {
                Clientes cliente = new Clientes
                {
                    Apellido = clienteDTO.Apellido,
                    DNI = clienteDTO.DNI,
                    Nombre = clienteDTO.Nombre
                };

                using (contexto = new Contexto())
                {
                    contexto.Clientes.Add(cliente);
                    contexto.SaveChanges();
                }

                return cliente.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(ClienteDTO clienteDTO)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    Clientes cliente = contexto.Clientes.Find(clienteDTO.Id);
                    cliente.Apellido = clienteDTO.Apellido;
                    cliente.DNI = clienteDTO.DNI;
                    cliente.Nombre = clienteDTO.Nombre;
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
                   var cliente = contexto.Clientes.Find(id);
                    contexto.Clientes.Remove(cliente);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ClienteDTO> ObtenerClientes()
        {
            List<ClienteDTO> listaClientesDTO = new List<ClienteDTO>();
            List<Clientes> listaClientes = new List<Clientes>();
            try
            {
                using (contexto = new Contexto())
                {
                    listaClientes = contexto.Clientes.ToList();
                }

                foreach (var cliente in listaClientes)
                {
                    ClienteDTO clienteDTO = new ClienteDTO()
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Apellido = cliente.Apellido,
                        DNI = cliente.DNI
                    };

                    listaClientesDTO.Add(clienteDTO);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return listaClientesDTO;
        }

        public List<ClienteDTO> BuscarClientes(string texto)
        {
            List<ClienteDTO> listaClientesDTO = new List<ClienteDTO>();
            List<Clientes> listaClientes = new List<Clientes>();
            try
            {
                using (contexto = new Contexto())
                {
                    listaClientes = contexto.Clientes  // con exp lambda busco en dos campos de la tabla el texto
                                    .Where(datos => contexto.Clientes.Any(x => datos.Apellido.Contains(texto)) ||
                                            contexto.Clientes.Any(x => datos.Nombre.Contains(texto))).ToList();
                }

                foreach (var cliente in listaClientes)
                {
                    ClienteDTO clienteDTO = new ClienteDTO
                    {
                        Id = cliente.Id,
                        Nombre = cliente.Nombre,
                        Apellido = cliente.Apellido,
                        DNI = cliente.DNI
                    };

                    listaClientesDTO.Add(clienteDTO);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return listaClientesDTO;
        }
    }
}
