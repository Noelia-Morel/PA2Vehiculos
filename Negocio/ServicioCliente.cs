using Negocio.Entidades;
using Datos;
using Datos.Entidades;
using System;

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

    }
}
