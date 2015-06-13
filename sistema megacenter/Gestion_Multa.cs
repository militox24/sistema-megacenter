using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Multa
    {
        private Conexion conn = new Conexion();
        public DataSet rescata_vendedores(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Vendedor where Rut=@rut ", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Vendedor");
            conn.desconectar();
            return ds;
        }
        public DataSet rescata_Multas()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut_Vendedor,Motivo,Detalle_Multa,Monto,Fecha from Multa", conn.conector);
            da.Fill(ds, "Multa");
            conn.desconectar();
            return ds;
        }
        public void Agregar_multa(string rut,string motivo,string detalle,int monto,string fecha,string rut_administrador)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Multa(Rut_Vendedor,Motivo,Detalle_Multa,Monto,Fecha,Rut_Administrador) VALUES (@rut,@motivo,@detalle,@monto,@fecha,@rut_administrador );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut", rut));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@motivo", motivo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@detalle", detalle));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@monto", monto));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fecha", fecha));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut_administrador", rut_administrador));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet buscar_multa(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut_Vendedor,Motivo,Detalle_Multa,Monto,Fecha from Multa where Rut_Vendedor=@rut ", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Multa");
            conn.desconectar();
            return ds;
        }
        public void Eliminar_Multa(string Rut)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from Multa where Rut_Vendedor=@rut", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@rut", Rut));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }

    }
}
