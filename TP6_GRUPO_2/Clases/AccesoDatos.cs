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
        catch (Exception) { return null; }
    }

    public SqlDataAdapter ObtenerAdaptador(string consulta)
    {
        SqlDataAdapter adaptador;
        try
        {
            adaptador = new SqlDataAdapter(consulta, ObtenerConexion());
            return adaptador;
        }
        catch (Exception){ return null; }
    }
    public int EjecutarProcedimientoAlmacenado(SqlCommand comandoSQL, string ProcedimientoAlmacenado) 
    {
        int FilasCambiadas;
        SqlConnection Conexion = ObtenerConexion();
        SqlCommand sqlCommand = new SqlCommand(); 
        sqlCommand = comandoSQL; 
        sqlCommand.Connection = Conexion;
        sqlCommand.CommandType = CommandType.StoredProcedure;  
        sqlCommand.CommandText = ProcedimientoAlmacenado; 
        FilasCambiadas = sqlCommand.ExecuteNonQuery();  
        Conexion.Close();
        return FilasCambiadas;
    }
}
