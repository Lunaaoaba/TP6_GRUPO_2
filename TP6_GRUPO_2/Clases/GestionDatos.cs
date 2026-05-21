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
    }
}