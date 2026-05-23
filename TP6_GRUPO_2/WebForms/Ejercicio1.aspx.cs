using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_Grupo_2_V1.Clases;

namespace TP6_GRUPO_2.WebForms
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CargarGridView();
            }
        }
    
private void CargarGridView()
        {
            GestionDatos gestionProductos = new GestionDatos();
            gvProductos.DataSource = gestionProductos.TablaProductos(); 
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;

            CargarGridView();
        }
    }
}