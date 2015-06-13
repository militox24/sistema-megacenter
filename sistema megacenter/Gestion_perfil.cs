using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_perfil
    {
        Conexion conn = new Conexion();
        public DataSet Rescatar_datos(string Rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Administrador where Rut=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", Rut));
            da.Fill(ds, "Administrador");
            conn.desconectar();
            return ds;
        }
        public void modificadatosperfil(string rut, string nombre,string apellido,string sexo,string direccion,string ciudad,string correo,string clave,string pregunta,string respuesta,int telefono,string url)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Administrador SET Nombres=@nombre,Apellidos=@apellidos,Sexo=@sexo,Direccion=@direccion,Ciudad=@ciudad,Correo=@correo,Clave=@clave,Pregunta=@pregunta,Respuesta=@respuesta,Telefono=@telefono,Url=@url where Rut=@rut", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@nombre", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@apellidos", apellido);
            da.UpdateCommand.Parameters.AddWithValue("@sexo", sexo);
            da.UpdateCommand.Parameters.AddWithValue("@direccion", direccion);
            da.UpdateCommand.Parameters.AddWithValue("@ciudad", ciudad);
            da.UpdateCommand.Parameters.AddWithValue("@correo", correo);
            da.UpdateCommand.Parameters.AddWithValue("@clave", clave);
            da.UpdateCommand.Parameters.AddWithValue("@pregunta", pregunta);
            da.UpdateCommand.Parameters.AddWithValue("@respuesta", respuesta);
            da.UpdateCommand.Parameters.AddWithValue("@telefono", telefono);
            da.UpdateCommand.Parameters.AddWithValue("@url", url);
            da.UpdateCommand.Parameters.AddWithValue("@rut", rut);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }


    }
}
