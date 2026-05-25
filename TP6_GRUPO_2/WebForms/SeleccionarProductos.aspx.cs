using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_Grupo_2_V1.Clases;

namespace TP6_Grupo_2_V1.WebForms
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            GestionDatos gestionDatos = new GestionDatos();
            gvProductos.DataSource = gestionDatos.TablaProductos();
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }

        protected void gvProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string NombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;

            lblMensaje.Text = "Usted ha seleccionado el producto: " + NombreProducto;
        }
    }

}