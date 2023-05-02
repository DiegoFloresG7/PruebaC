using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaC
{
    public partial class Nomina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() != "")
            {
                if (txtNumero.Text.Trim() != "0")
                {
                    ServicioEmpleado.WCFEmpleadoClient Consulta = new ServicioEmpleado.WCFEmpleadoClient();
                    ServicioEmpleado.DTOEmpleado datos = new ServicioEmpleado.DTOEmpleado();
                    datos = Consulta.ConsultaEmpleado(Convert.ToInt32(txtNumero.Text));
                    if (datos.Nombre == null)
                    {
                        string script = string.Format("alert('No se encontraron datos con el numero de empleado proporcionado...');");
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    }
                }
         
             
            }
            else
            {
                string script = string.Format("alert('Favor de teclear un numero de empleado...');");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        private bool validaDatoGuardar()
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (txtNumero.Text.Trim() == "")
            {
                sb.Append("Favor de seleccionar un numero empleado. \\n ");
            }
            if (txtDate.Text.Trim() == "")
            {
                
                sb.Append("Favor de seleccionar un mes. ");
            }

            if (sb.Length > 0)
            {

                string script = string.Format("alert('{0}');", sb.ToString());
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", script, true);

                result = false;
            }

            return result;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validaDatoGuardar())
            {
                ServicioEmpleado.WCFEmpleadoClient Consulta = new ServicioEmpleado.WCFEmpleadoClient();
                ServicioEmpleado.DTOEmpleado Datos = new ServicioEmpleado.DTOEmpleado();
                Datos.IdEmpleado = Convert.ToInt32(txtNumero.Text);
                Datos.IdMes = Convert.ToInt32(txtDate.Text.Split('-')[1]);
                gvNomina.DataSource = Consulta.ConsultaNominao(Datos).ToList();
                gvNomina.DataBind();
            }
        }
    }
}