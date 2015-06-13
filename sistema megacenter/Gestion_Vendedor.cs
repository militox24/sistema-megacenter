using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sistema_megacenter
{
    class Gestion_Vendedor
    {
        private Conexion conn = new Conexion();

        public void AgregarVendedor(string rut, string nombres, string apellidos, int telefono, string direccion, string ciudad, string correo, string clave, string Fecha_Ingreso, string Fecha_Nacimiento,string pregunta,string respuesta, int sueldo, string url)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Vendedor(Rut,Nombres,Apellidos,Telefono,Dirección,Ciudad,Correo,Clave,Fecha_Ingreso,Fecha_Nacimiento,Pregunta,Respuesta,Sueldo,Url) VALUES (@rut,@nombres,@apellidos,@telefono,@direccion,@ciudad,@correo,@clave,@fecha_ingreso,@fecha_nacimiento,@pregunta,@respuesta,@sueldo,@url );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut", rut));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombres", nombres));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@telefono", telefono));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@direccion", direccion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@correo", correo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@clave", clave));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fecha_ingreso", Fecha_Ingreso));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fecha_nacimiento", Fecha_Nacimiento));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@pregunta", pregunta));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@respuesta", respuesta));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@sueldo", sueldo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@url", url));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet verificarexistencia(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Vendedor where Rut=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Vendedor");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatardatosvendedor()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut,Nombres,Apellidos,Dirección,Correo from Vendedor", conn.conector);
            da.Fill(ds, "Vendedor");
            conn.desconectar();
            return ds;
        }
        public void Eliminar_Vendedor(string Rut)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from Vendedor where Rut=@rut", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@rut", Rut));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void modificar_vendedor(string rut,string nombre,string apellido,int telefono,string direccion,string ciudad,string fecha_nacimiento,string pregunta,string respuesta,string clave,int sueldo,string email,string url_imagen)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Vendedor SET Nombres=@nombre,Apellidos=@apellidos,Telefono=@telefono,Dirección=@direccion,Ciudad=@ciudad,Correo=@correo,Clave=@clave,Fecha_Nacimiento=@fecha,Pregunta=@pregunta,Respuesta=@respuesta,Sueldo=@sueldo,Url=@imagen where Rut=@rut", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@rut",rut );
            da.UpdateCommand.Parameters.AddWithValue("@nombre",nombre);
            da.UpdateCommand.Parameters.AddWithValue("@apellidos",apellido );
            da.UpdateCommand.Parameters.AddWithValue("@telefono",telefono );
            da.UpdateCommand.Parameters.AddWithValue("@direccion",direccion );
            da.UpdateCommand.Parameters.AddWithValue("@ciudad",ciudad );
            da.UpdateCommand.Parameters.AddWithValue("@correo",email );
            da.UpdateCommand.Parameters.AddWithValue("@clave",clave );
            da.UpdateCommand.Parameters.AddWithValue("@fecha",fecha_nacimiento );
            da.UpdateCommand.Parameters.AddWithValue("@pregunta",pregunta );
            da.UpdateCommand.Parameters.AddWithValue("@respuesta",respuesta );
            da.UpdateCommand.Parameters.AddWithValue("@sueldo",sueldo );
            da.UpdateCommand.Parameters.AddWithValue("@imagen",url_imagen );
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void modificar_vendedor_perfil(string rut, string nombre, string apellido, int telefono, string direccion, string ciudad, string fecha_nacimiento, string pregunta, string respuesta, string clave,  string email, string url_imagen)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Vendedor SET Nombres=@nombre,Apellidos=@apellidos,Telefono=@telefono,Dirección=@direccion,Ciudad=@ciudad,Correo=@correo,Clave=@clave,Fecha_Nacimiento=@fecha,Pregunta=@pregunta,Respuesta=@respuesta,Url=@imagen where Rut=@rut", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@rut", rut);
            da.UpdateCommand.Parameters.AddWithValue("@nombre", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@apellidos", apellido);
            da.UpdateCommand.Parameters.AddWithValue("@telefono", telefono);
            da.UpdateCommand.Parameters.AddWithValue("@direccion", direccion);
            da.UpdateCommand.Parameters.AddWithValue("@ciudad", ciudad);
            da.UpdateCommand.Parameters.AddWithValue("@correo", email);
            da.UpdateCommand.Parameters.AddWithValue("@clave", clave);
            da.UpdateCommand.Parameters.AddWithValue("@fecha", fecha_nacimiento);
            da.UpdateCommand.Parameters.AddWithValue("@pregunta", pregunta);
            da.UpdateCommand.Parameters.AddWithValue("@respuesta", respuesta);
            da.UpdateCommand.Parameters.AddWithValue("@imagen", url_imagen);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
