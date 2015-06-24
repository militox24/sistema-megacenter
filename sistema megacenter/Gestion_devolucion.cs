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
    }
}
