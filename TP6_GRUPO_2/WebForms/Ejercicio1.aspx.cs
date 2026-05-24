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

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idporoducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_IdProducto")).Text;

            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(idporoducto);

            GestionDatos gestion = new GestionDatos(); 
            gestion.EliminarProducto(producto);

            CargarGridView(); 
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string idproducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
            string nombreproducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_nombreProducto")).Text;
            string cantidadporunidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_cantidadXunidad")).Text;
            string preciounidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_precioUnidad")).Text;

            Producto producto = new Producto(Convert.ToInt32(idproducto), nombreproducto, cantidadporunidad, Convert.ToDecimal(preciounidad));

            GestionDatos gestion = new GestionDatos();
            gestion.ActualizarProducto(producto);
            gvProductos.EditIndex = -1;
            CargarGridView(); 
        }
    }
}