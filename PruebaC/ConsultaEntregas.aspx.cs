using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaC
{
    public partial class ConsultaEntregas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaCatalogos();
            }
        }
        protected void  CargaCatalogos()
        {
            ServiceReference1.WCFCatalogoClient ConsultaCatalogo = new ServiceReference1.WCFCatalogoClient();
            //List<ServiceReference1.DTOGenerico> ListRoles = new List<ServiceReference1.DTOGenerico>();
            //ListRoles = 
            ddlRol.DataSource = ConsultaCatalogo.ConsultaROles().ToList();
            ddlRol.DataBind();
        }

        protected void Limpia()
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtEntregas.Text = "";
            ddlRol.SelectedValue = "0";
            txtDate.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private bool validaDatoGuardar()
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (txtNombre.Text.Trim() == "")
            {
                sb.Append("Favor de teclear un nombre. \\n");
            }
            if (ddlRol.SelectedValue == "0")
            {
                sb.Append("Favor de seleccionar un rol. \\n");
            }
            if (txtNumero.Text.Trim() == "")
            {
                sb.Append("Favor de seleccionar un numero empleado. \\n ");
            }
            if (txtDate.Text.Trim() == "")
            {
                int a = Convert.ToInt32(txtDate.Text.Split('-')[1]);
                sb.Append("Favor de seleccionar un mes. ");
            }
            if (txtEntregas.Text.Trim() == "")
            {
                sb.Append("Favor de seleccionar un numero empleado. \\n ");
            }

            if (sb.Length > 0)
            {

                string script = string.Format("alert('{0}');", sb.ToString());
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", script, true);

                result = false;
                //string script2 = string.Format("alert('{0}');", sb.ToString());
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", script2, true);
            }

            return result;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaDatoGuardar())
            {
                ServicioEmpleado.WCFEmpleadoClient Guarda = new ServicioEmpleado.WCFEmpleadoClient();
                int guardo = 0;
                ServicioEmpleado.DTOEmpleado datos = new ServicioEmpleado.DTOEmpleado();
                datos.IdEmpleado = Convert.ToInt32(txtNumero.Text);
                datos.Nombre = txtNombre.Text;
                datos.IdRol = Convert.ToInt32(ddlRol.SelectedValue);
                datos.IdMes = Convert.ToInt32(txtDate.Text.Split('-')[1]);
                datos.IdEntregas = Convert.ToInt32(txtEntregas.Text);
                guardo = Guarda.GuardaEntregasEMpleados(datos);
                if (guardo > 0)
                {
                    string script = string.Format("alert('Se ha guardado con èxito...');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    Limpia();
                    
                }
                else
                {
                    string script = string.Format("alert('Ha ocurrido un detalle al guardar, favor de verificar...');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() != "")
            {
                ServicioEmpleado.WCFEmpleadoClient Consulta = new ServicioEmpleado.WCFEmpleadoClient();
                ServicioEmpleado.DTOEmpleado datos = new ServicioEmpleado.DTOEmpleado();
                datos = Consulta.ConsultaEmpleado(Convert.ToInt32(txtNumero.Text));
                if (datos.Nombre != null)
                {
                    txtNombre.Text = datos.Nombre;
                    ddlRol.SelectedValue = datos.IdRol.ToString();
                }
                else
                {
                    string script = string.Format("alert('No se encontraron datos con el numero de empleado proporcionado...');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }
            }
            else
            {
                string script = string.Format("alert('Favor de teclear un numero de empleado...');");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }
    }
}