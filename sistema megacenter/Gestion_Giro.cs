using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sistema_megacenter
{
    class Gestion_Giro
    {
        Conexion conn = new Conexion();
        public void registrar_giro(string nombre_giro, string descripcion)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Giro(Nombre_Giro,Descripcion) VALUES (@giro,@descripcion);", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@giro",nombre_giro));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet verificar_giro(string nombre_giro)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Giro where Nombre_Giro=@giro", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@giro", nombre_giro));
            da.Fill(ds, "Giro");
            conn.desconectar();
            return ds;
        }
        public DataSet Buscar_giro(string nombre_giro)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Giro,Descripcion from Giro where Nombre_Giro=@giro", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@giro", nombre_giro));
            da.Fill(ds, "Giro");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatar_giros()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Giro,Descripcion from Giro", conn.conector);
            da.Fill(ds, "Giro");
            conn.desconectar();
            return ds;
        }
        public void Elimina_Giro(string giro)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from Giro where Nombre_Giro=@giro", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@giro", giro));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
