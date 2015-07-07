using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_devolucion
    {
        Conexion conn = new Conexion();
        public DataSet buscar_venta(int numero_venta)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Cantidad,Producto,Precio,Subtotal from Detalle_Venta where N_Venta=@numero", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@numero", numero_venta));
            da.Fill(ds, "Detalle_Venta");
            conn.desconectar();
            return ds;
        }

        public DataSet buscar_devolucion(int numero_boleta)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Producto,Unidades_Devueltas,Motivo,Fechafrom Devolucion where N_Venta=@numero", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@numero", numero_boleta));
            da.Fill(ds, "Devolucion");
            conn.desconectar();
            return ds;
        }

        public DataSet rescata_unidades(string  producto)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Unidades_Devueltas from Devolucion where Producto=@producto", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@producto",producto ));
            da.Fill(ds, "Devolucion");
            conn.desconectar();
            return ds;
        }
        public void Agregar_devolucion(string producto, int unidades, string motivo, string fecha, int numeroventa)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Devolucion(Producto,Unidades_Devueltas,Motivo,Fecha,N_Venta) VALUES (@producto,@unidades,@motivo,@fecha,@nventa );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@producto", producto));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@unidades", unidades));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@motivo", motivo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@fecha", fecha));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nventa", numeroventa));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
