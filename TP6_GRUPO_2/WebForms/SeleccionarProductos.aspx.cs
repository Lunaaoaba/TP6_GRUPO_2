using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
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
            string IdProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string NombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string IdProveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            string PrecioUnitario = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text;


            lblMensaje.Text = "Usted ha seleccionado el producto: " + NombreProducto;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = CreateTabla();
            }
            agregarFila((DataTable)Session["tabla"], IdProducto, NombreProducto, IdProveedor, PrecioUnitario);
        }
        private DataTable CreateTabla()
        {
            DataTable dataTable = new DataTable();

            DataColumn dataColumn = new DataColumn("IdProducto", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Nombre de Producto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("IdProveedor", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Precio Unidad", System.Type.GetType("System.Decimal"));
            dataTable.Columns.Add(dataColumn);

            return dataTable;
        }
        private DataTable agregarFila(DataTable dataTable, string IdProducto, string NombreProducto, string IdProveedor, string PrecioUnitario)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow["IdProducto"] = Convert.ToInt32(IdProducto);
            dataRow["Nombre de Producto"] = NombreProducto;
            dataRow["IdProveedor"] = Convert.ToInt32(IdProveedor);
            dataRow["Precio Unidad"] = Convert.ToDecimal(PrecioUnitario);
            dataTable.Rows.Add(dataRow);

            return dataTable;
        }
    }

}