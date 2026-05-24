using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TP6_Grupo_2_V1.Clases
{
    public class GestionDatos
    {
        private DataTable ObtenerTabla(string nombretabla, string consulta)
        {
            DataSet set = new DataSet();
            AccesoDatos acceso = new AccesoDatos();
            SqlDataAdapter adaptador = acceso.ObtenerAdaptador(consulta);
            adaptador.Fill(set, nombretabla);
            return set.Tables[nombretabla];
        }
        public DataTable TablaProductos()
        {
            return ObtenerTabla("Productos", "SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM Productos");
        }
        
        
        private void ArmarParametrosProductosEliminar(ref SqlCommand Comando, Producto producto)
        {
            SqlParameter parametro = new SqlParameter();
            parametro = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            parametro.Value = producto.IdProducto;
        }

        private void ArmarParametrosProductosActualizar(ref SqlCommand Comando, Producto producto)
        { 
            SqlParameter parametro = new SqlParameter();

            parametro = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            parametro.Value = producto.IdProducto;

            parametro = Comando.Parameters.Add("@NombreProducto", SqlDbType.VarChar);
            parametro.Value = producto.NombreProducto;

            parametro = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.VarChar);
            parametro.Value = producto.CantidadPorUnidad;

            parametro = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Decimal);
            parametro.Value = producto.PrecioUnidad;
        }

        public bool ActualizarProducto(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductosActualizar(ref comando, producto);
            AccesoDatos acceso = new AccesoDatos();
            int filasAfectadas = acceso.EjecutarProcedimientoAlmacenado(comando, "spActualizarProducto");
            
            if(filasAfectadas == 1)
                return true;
            else 
                return false;
        }

        public bool EliminarProducto(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductosEliminar(ref comando, producto);
            AccesoDatos acceso = new AccesoDatos();
            int filasAfectadas = acceso.EjecutarProcedimientoAlmacenado(comando, "spEliminarProducto");

            if(filasAfectadas == 1)
                return true;
            else 
                return false;
        }
    }
    
}
    