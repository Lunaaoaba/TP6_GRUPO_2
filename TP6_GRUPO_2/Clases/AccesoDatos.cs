using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class AccesoDatos
{
    private const string rutaNeptuno = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Neptuno; Integrated Security = True";

    public SqlConnection ObtenerConexion()
    {
        SqlConnection conexion = new SqlConnection(rutaNeptuno);
        try
        {
            conexion.Open();
            return conexion;
        }
        catch (Exception)
        { 
            return null;
        }
    }

    public SqlDataAdapter ObtenerAdaptador(string consulta)
    {
        SqlDataAdapter adaptador;
        try
        {
            adaptador = new SqlDataAdapter(consulta, ObtenerConexion());
            return adaptador;
        }
        catch (Exception)
        { 
            return null;
        }
    }
    public int EjecutarProcedimientoAlmacenado(SqlCommand comandoSQL, string ProcedimientoAlmacenado) 
    {
        SqlConnection Conexion = ObtenerConexion();
        if (Conexion == null)
            return 0;

        try
        {
            comandoSQL.Connection = Conexion;
            comandoSQL.CommandType = CommandType.StoredProcedure;  
            comandoSQL.CommandText = ProcedimientoAlmacenado;
            int FilasCambiadas = comandoSQL.ExecuteNonQuery();
            return FilasCambiadas;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("Error en procedimiento: " + ex.Message);
            return 0;
        }
        finally
        {
            if (Conexion != null && Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}
