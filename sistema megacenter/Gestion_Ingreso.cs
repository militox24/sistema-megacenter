using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_megacenter
{
    class Gestion_Ingreso
    {
        private Conexion conn = new Conexion();
        public DataSet Ingreso_Sistema(string rut, string clave, string usuario)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + usuario + " where Rut=@rut and Clave=@clave and Estado='Activo'", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.SelectCommand.Parameters.Add(new SqlParameter("@clave", clave));
            da.Fill(ds, "" + usuario + "");
            conn.desconectar();
            return ds;
        }
        public DataSet Datos_recupera(string rut, string usuario)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + usuario + " where Rut=@rut and Estado='Activo'", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "" + usuario + "");
            conn.desconectar();
            return ds;
        }
        public void modificarClave(string clave,string usuariologueado,string rut)
        {
            
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE "+usuariologueado+" SET Clave=@clave WHERE Rut=@Rut ", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@Clave", clave);
            da.UpdateCommand.Parameters.AddWithValue("@Rut", rut);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }

    }
}
