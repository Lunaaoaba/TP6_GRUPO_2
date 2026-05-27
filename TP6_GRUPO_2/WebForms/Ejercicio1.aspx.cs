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
            try
            {
                string idporoducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_IdProducto")).Text;

                Producto producto = new Producto();
                producto.IdProducto = Convert.ToInt32(idporoducto);

                GestionDatos gestion = new GestionDatos(); 
                bool resultado = gestion.EliminarProducto(producto);

                if (resultado)
                {
                    CargarGridView();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error: No se eliminó el producto");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en eliminación: " + ex.Message);
            }
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
            try
            {
                string idproducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_idProducto")).Text;
                string nombreproducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_nombreProducto")).Text;
                string cantidadporunidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_cantidadXunidad")).Text;
                string preciounidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_precioUnidad")).Text;

                preciounidad = preciounidad.Trim().Replace(",", ".");
                decimal precioDecimal = Convert.ToDecimal(preciounidad);

                Producto producto = new Producto(Convert.ToInt32(idproducto), nombreproducto, cantidadporunidad, precioDecimal);

                GestionDatos gestion = new GestionDatos();
                bool resultado = gestion.ActualizarProducto(producto);

                if (resultado)
                {
                    gvProductos.EditIndex = -1;
                    CargarGridView();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error: No se actualizó el producto");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en actualización: " + ex.Message);
            }
        }
    }
}