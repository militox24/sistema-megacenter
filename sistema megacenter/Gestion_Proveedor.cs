using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Proveedor
    {
        Conexion conn = new Conexion();
        public DataSet verificarexistenciaproveedor(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Proveedor where Rut=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Proveedor");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatartodoslosproveedores()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Proveedor", conn.conector);
            da.Fill(ds, "Proveedor");
            conn.desconectar();
            return ds;
        }
        public void ingresarproveedor(string rut, string nombre,string descripcion,string direccion,string ciudad,string giro,int telefono,string email,string url)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Proveedor(Rut,Nombres,Descripcion,Dirección,Ciudad,Giro,Telefono,Email,Url) VALUES (@rut,@nombre,@descripcion,@direccion,@ciudad,@giro,@telefono,@email,@url );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut", rut));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@direccion", direccion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@giro", giro));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@telefono", telefono));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@email", email));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@url", url));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void Eliminar_Proveedor(string Rut)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from Proveedor where Rut=@rut", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@rut", Rut));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet Buscar_Proveedor(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Proveedor where Rut=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Proveedor");
            conn.desconectar();
            return ds;
        }
        public void modificadatosproveedor(string rut, string nombre, string descripcion, string direccion, string ciudad, string giro, int fono, string email, string url)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Proveedor SET Nombres=@nombre,Descripcion=@descripcion,Dirección=@direccion,Ciudad=@ciudad,Giro=@giro,Telefono=@fono,Email=@email,Url=@url where Rut=@rut", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@nombre", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@descripcion", descripcion);
            da.UpdateCommand.Parameters.AddWithValue("@direccion", direccion);
            da.UpdateCommand.Parameters.AddWithValue("@ciudad", ciudad);
            da.UpdateCommand.Parameters.AddWithValue("@giro", giro);
            da.UpdateCommand.Parameters.AddWithValue("@fono", fono);
            da.UpdateCommand.Parameters.AddWithValue("@email",email);
            da.UpdateCommand.Parameters.AddWithValue("@url", url);
            da.UpdateCommand.Parameters.AddWithValue("@rut", rut);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
