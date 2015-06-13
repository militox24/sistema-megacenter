using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sistema_megacenter
{
    class Gestion_Compra
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
        public DataSet todos_los_proveedores()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Rut from Proveedor", conn.conector);
            da.Fill(ds, "Proveedor");
            conn.desconectar();
            return ds;
        }
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
        public void ingresar_compra(int compra,string rutproveedor, string fecha, int neto, int iva, int total,string rutadministrador)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Compra(N_Compra,Rut_Proveedor,Fecha,Neto,Iva,Total,Rut_Administrador)values(@compra,@proveedor,@fecha,@neto,@iva,@total,@rutadministrador)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@compra", compra));
            da.InsertCommand.Parameters.Add(new SqlParameter("@proveedor", rutproveedor));
            da.InsertCommand.Parameters.Add(new SqlParameter("@fecha", fecha));
            da.InsertCommand.Parameters.Add(new SqlParameter("@neto", neto));
            da.InsertCommand.Parameters.Add(new SqlParameter("@iva", iva));
            da.InsertCommand.Parameters.Add(new SqlParameter("@total", total));
            da.InsertCommand.Parameters.Add(new SqlParameter("@rutadministrador", rutadministrador));
            da.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void ingresar_detallecompra( int cantidad, int codigo,int precio,int total,int compra)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into Detalle_Compra(Cantidad,Cod_Producto,Precio,Subtotal,N_Compra)values(@cantidad,@codigo,@precio,@total,@compra)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", cantidad));
            da.InsertCommand.Parameters.Add(new SqlParameter("@codigo", codigo));
            da.InsertCommand.Parameters.Add(new SqlParameter("@precio", precio));
            da.InsertCommand.Parameters.Add(new SqlParameter("@total", total));
            da.InsertCommand.Parameters.Add(new SqlParameter("@compra", compra));
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

