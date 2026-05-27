using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_Grupo_2_V1.WebForms
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void lbEliminarProducto_Click(object sender, EventArgs e)
        {
            Session.Clear();
        }
    }
}