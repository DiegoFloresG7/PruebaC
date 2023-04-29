using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.WCFCatalogoClient Catalogo = new ServiceReference1.WCFCatalogoClient();
           ServiceReference1.DTOEmpleado Da = new ServiceReference1.DTOEmpleado();
           Da = Catalogo.ConsultaEmpleado("Panchito");
           int numeroEmpleado = 1;
        }
    }
}