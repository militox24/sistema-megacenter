using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_venta
    {
        Conexion conn = new Conexion();
        public string TraerValor(string strCadena)
        {
            DataSet ds = EjecutaConsultaDataset(strCadena);
            DataRow row;
            if (ds.Tables[0].Rows.Count > 0)
            {
                row = ds.Tables[0].Rows[0];
                return row[0].ToString();
            }
            else
                return "";
        }
        private DataSet EjecutaConsultaDataset(string consulta)
        {
            SqlDataAdapter daCommand;
            DataSet dsGral;
            conn.conectar();
            try
            {

                daCommand = new SqlDataAdapter(consulta, conn.conector);
                dsGral = new DataSet();
                daCommand.Fill(dsGral);

                return dsGral;
            }
            catch (SqlException error)
            {
                return null;
            }
            finally
            {
                dsGral = null;
            }
        }
        //voy a usar para verificar el rut del cliente

        //public DataSet todos_los_proveedores()
        //{
        //    conn.conectar();
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter("select Rut from Proveedor", conn.conector);
        //    da.Fill(ds, "Proveedor");
        //    conn.desconectar();
        //    return ds;
        //}
        public DataSet informacion_productos(int codigo)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Producto.Nombre,Producto.Precio_Compra,Producto.Stock from Producto where Cod_Producto=@codigo", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("codigo", codigo));
            da.Fill(ds, "Producto");
            conn.desconectar();
            return ds;
        }
        public DataSet rescatarcodigoproducto(string nombre)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Producto.Cod_Producto  from Producto where Producto.Nombre=@nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            da.Fill(ds, "Producto");
            conn.desconectar();
            return ds;
        }
        public void ingresar_Venta(int n_venta, string fecha, string rutusuario, string rut_cliente,int neto, int iva, int total)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Venta(N_Venta,Fecha,Rut_Usuario,Rut_Cliente,Total_Neto,Iva,Total_Bruto)values(@venta,@fecha,@rut_usuario,@rut_cliente,@neto,@iva,@total)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@venta", n_venta));
            da.InsertCommand.Parameters.Add(new SqlParameter("@fecha", fecha));
            da.InsertCommand.Parameters.Add(new SqlParameter("@rut_usuario", rutusuario));
            da.InsertCommand.Parameters.Add(new SqlParameter("@rut_cliente", rut_cliente));
            da.InsertCommand.Parameters.Add(new SqlParameter("@neto", neto));
            da.InsertCommand.Parameters.Add(new SqlParameter("@iva", iva));
            da.InsertCommand.Parameters.Add(new SqlParameter("@total", total));
            da.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void ingresar_detalleventa(int cantidad, int codigo, int precio, int total, int venta)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Detalle_Venta(Cantidad,Cod_Producto,Precio,Subtotal,N_Venta)values(@cantidad,@codigo,@precio,@total,@venta)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", cantidad));
            da.InsertCommand.Parameters.Add(new SqlParameter("@codigo", codigo));
            da.InsertCommand.Parameters.Add(new SqlParameter("@precio", precio));
            da.InsertCommand.Parameters.Add(new SqlParameter("@total", total));
            da.InsertCommand.Parameters.Add(new SqlParameter("@venta", venta));
            da.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void Modificarstockproducto(int codigo, int unidades)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Producto set  Stock=@unidades where Cod_Producto=@Producto", conn.conector);
            da.UpdateCommand.Parameters.Add(new SqlParameter("@unidades", unidades));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Producto", codigo));
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
