using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaC
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDatos();
            }
        }

        protected void  CargaDatos()
        {
            ServiceReference1.WCFCatalogoClient ConsultaCatalogo = new ServiceReference1.WCFCatalogoClient();
            //List<ServiceReference1.DTOGenerico> ListRoles = new List<ServiceReference1.DTOGenerico>();
            //ListRoles = 
            ddlRol.DataSource = ConsultaCatalogo.ConsultaROles().ToList();
            ddlRol.DataBind();

            txtNumero.Text = ConsultaCatalogo.ConsultaIdNuevoEMpleado().ToString();
            txtNombre.Text = "";
           
        }

        protected void Limpia()
        {
            CargaDatos();
        }

        private bool validaDatoGuardar()
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (txtNombre.Text.Trim() == "")
            {
              sb.Append("Favor de teclear un nombre.");
            }
            if (ddlRol.SelectedValue == "0")
            {
                 sb.Append("Favor de seleccionar un rol.");
            }
          
            if (sb.Length > 0)
            {
                result = false;
                string script = string.Format("alert('{0}');", sb.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }

            return result;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validaDatoGuardar())
            {
                ServicioEmpleado.WCFEmpleadoClient Guarda = new ServicioEmpleado.WCFEmpleadoClient();
                ServicioEmpleado.DTOEmpleado Datos = new ServicioEmpleado.DTOEmpleado();
                Datos.Nombre = txtNombre.Text.Trim();
                Datos.IdRol = Convert.ToInt32(ddlRol.SelectedValue);

                int guardo = 0;
                guardo = Guarda.GuardaEMpleados(Datos);
                if (guardo > 0)
                {
                    string script = string.Format("alert('Se ha guardado con èxito...');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                    CargaDatos(); 
                }
                else
                {
                    string script = string.Format("alert('Ha ocurrido un detalle al guardar, favor de verificar...');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }

            }
        }

      
    }
}