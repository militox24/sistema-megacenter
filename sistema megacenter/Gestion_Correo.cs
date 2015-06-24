
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sistema_megacenter
{
    class Gestion_Correo
    {
        Conexion conn = new Conexion();
        public void guardar_mensaje(string emisor, string receptor,string asunto,string ruta,string mensaje)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Correo(Emisor,Destinatario,Asunto,Ruta_Archivo,Mensaje) VALUES (@emisor,@receptor,@asunto,@ruta,@mensaje);", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@emisor", emisor));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@receptor", receptor));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@asunto", asunto));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ruta", ruta));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@mensaje", mensaje));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }

        public DataSet rescata_correos(string correologueado)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Emisor,Asunto,Ruta_Archivo,Mensaje from Correo where Destinatario=@destinatario", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@destinatario", correologueado));
            da.Fill(ds, "Correo");
            conn.desconectar();
            return ds;
        }
        public void Eliminar_Mensaje(string asunto)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.DeleteCommand = new SqlCommand("Delete from Correo where Asunto=@asunto", conn.conector);
            dd.DeleteCommand.Parameters.Add(new SqlParameter("@asunto", asunto));
            dd.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }


    }
}
