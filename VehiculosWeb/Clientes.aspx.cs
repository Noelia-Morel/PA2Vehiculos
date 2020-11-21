using Negocio;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VehiculosWeb
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            int idNuevo = 0;
            if (Page.IsValid)
            {
                ItemCliente itemCliente = new ItemCliente()
                {
                    DNI = long.Parse(txtDNI.Text),
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text
                };

                idNuevo = ServicioCliente.AgregarCliente(itemCliente);
            }

            if (idNuevo > 0)
            {
                BlanquearCampos();
            }
        }

        private void BlanquearCampos()
        {
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
    }
}