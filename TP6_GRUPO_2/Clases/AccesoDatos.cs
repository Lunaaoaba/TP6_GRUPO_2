using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class AccesoDatos
{
    string rutaNeptuno = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Neptuno; Integrated Security = True";

    public SqlConnection ObtenerConexion()
    {
        SqlConnection conexion = new SqlConnection(rutaNeptuno);
        try
        {
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
