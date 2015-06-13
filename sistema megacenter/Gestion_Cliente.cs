using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Cliente
    {
        Conexion conn = new Conexion();
        public void insertarCliente(string rut, string nombre, string apellidos, string fecha_nacimiento, string direccion, string ciudad, int fono, string sexo, string correo_electronico)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Cliente(Rut_Cliente,Nombres,Apellidos,Fecha_Nacimiento,Direccion,Ciudad,Fono,Sexo,Correo_Electronico) VALUES (@rut,@nombres,@apellidos,@fecha_nacimiento,@direccion,@ciudad,@fono,@sexo,@correo_electronico);", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut", rut));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombres", nombre));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fecha_nacimiento", fecha_nacimiento));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@direccion", direccion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fono", fono));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@sexo", sexo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@correo_electronico", correo_electronico));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet verificarexistencia(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Cliente where Rut_Cliente=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Cliente");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatardatoscliente()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut_Cliente,Nombres,Apellidos,Direccion,Correo_Electronico from Cliente", conn.conector);
            da.Fill(ds, "Cliente");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatardatosclientes(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut_Cliente,Nombres,Apellidos,Direccion,Correo_Electronico from Cliente where Rut_Cliente=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Cliente");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatadatosmod(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Cliente where Rut_Cliente=@rut ", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Cliente");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatanombreciudadmod(int ciudad)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Ciudad from Ciudad where Id_Ciudad=@ciudad ", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            da.Fill(ds, "Ciudad");
            conn.desconectar();
            return ds;
        }
        public void Elimina_cliente(string rut)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("Delete from Cliente where Rut_Cliente=@rut", conn.conector);
            da.DeleteCommand.Parameters.AddWithValue("@rut", rut);
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet rescatarruts()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut_Cliente from Cliente ", conn.conector);
            da.Fill(ds, "Cliente");
            conn.desconectar();
            return ds;
        }
        public void modificadatoscliente(string rut, string nombre, string apellidos, string fecha_nacimiento, string direccion, string ciudad, int fono, string sexo, string correo_electronico)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Cliente SET Nombres=@nombres,Apellidos=@apellidos,Fecha_Nacimiento=@fecha_nacimiento,Direccion=@direccion,Ciudad=@ciudad,Fono=@fono,Sexo=@sexo,Correo_Electronico=@correo where Rut_Cliente=@rut", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@nombres", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@apellidos", apellidos);
            da.UpdateCommand.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            da.UpdateCommand.Parameters.AddWithValue("@direccion", direccion);
            da.UpdateCommand.Parameters.AddWithValue("@ciudad", ciudad);
            da.UpdateCommand.Parameters.AddWithValue("@fono", fono);
            da.UpdateCommand.Parameters.AddWithValue("@sexo", sexo);
            da.UpdateCommand.Parameters.AddWithValue("@correo", correo_electronico);
            da.UpdateCommand.Parameters.AddWithValue("@rut", rut);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
