using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Pagos
    {
        Conexion conn = new Conexion();
        public DataSet verificarpagos(string rut)
        {
            conn.conectar();

            DataSet ds = new DataSet();
            string tipo = "Credito";
            string estado = "Sin Pagar";
            SqlDataAdapter da = new SqlDataAdapter("select N_Venta,Fecha,Rut_Usuario,Total_Bruto from Venta where Rut_Cliente=@cliente and Tipo=@tipo and Estado=@estado", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@cliente", rut));
            da.SelectCommand.Parameters.Add(new SqlParameter("@tipo", tipo));
            da.SelectCommand.Parameters.Add(new SqlParameter("@estado", estado));
            da.Fill(ds, "Venta");
            conn.desconectar();
            return ds;
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
        public void modificaestadoventa(int venta)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            string estado = "Pagada";
            da.UpdateCommand = new SqlCommand("UPDATE Venta SET Estado=@estado where N_Venta=@venta", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@estado", estado);
            da.UpdateCommand.Parameters.AddWithValue("@venta", venta);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }

    }
}
