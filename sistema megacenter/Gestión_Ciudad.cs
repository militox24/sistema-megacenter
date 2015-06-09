using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace sistema_megacenter
{
    class Gestión_Ciudad
    {
        private Conexion conn = new Conexion();
        public void insertarCiudad(string ciudad, string descripcion)
        {
            conn.conectar();
            string estado = "Activo";
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Ciudad(Nombre_Ciudad,Descripción,Estado) VALUES (@ciudad,@descripcion,@estado );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@estado", estado));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet verificarciudad(string nombre_ciudad)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ciudad where Nombre_Ciudad=@ciudad", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ciudad", nombre_ciudad));
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public DataSet Buscar_Ciudad(string nombre)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Ciudad,Descripción from Ciudad where Nombre_Ciudad=@nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatardatosciudad()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Ciudad,Descripción from Ciudad", conn.conector);
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatardatosciudades()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Ciudad from Ciudad", conn.conector);
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public void Elimina_ciudad(string ciudad)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand= new SqlCommand("delete from Ciudad where Nombre_Ciudad=@ciudad", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet Rescatar_id(string nombre)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Id_Ciudad from Ciudad where Nombre_Ciudad=@nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public void modificadatosciudad(string nombre,string descripcion)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Ciudad SET Descripción=@descripcion where Nombre_Ciudad=@nombre", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@nombre", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@descripcion", descripcion);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
