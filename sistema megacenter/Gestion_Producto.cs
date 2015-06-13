using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Producto
    {
        Conexion conn = new Conexion();
        public DataSet verificarproducto(int codigo)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Producto where Cod_Producto=@codigo", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@codigo", codigo));
            da.Fill(ds, "Producto");
            conn.desconectar();
            return ds;
        }
        public void Elimina_Producto(int codigo)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("Delete from Producto where Cod_Producto=@codigo", conn.conector);
            da.DeleteCommand.Parameters.AddWithValue("@codigo", codigo);
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void modificadatosproducto(int codigo, string nombre, string descripcion, string categoria, string proveedor, int stock, int stock_critico, int precio_venta, int precio_compra, string url)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("UPDATE Producto SET Nombre=@nombre,Descripcion=@descripcion,Categoria=@categoria,Proveedor=@proveedor,Stock=@stock,Stock_Critico=@stock_critico,Precio_Venta=@precio_venta,Precio_Compra=@precio_compra,Url_Imagen=@imagen where Cod_Producto=@codigo", conn.conector);
            da.UpdateCommand.Parameters.AddWithValue("@nombre", nombre);
            da.UpdateCommand.Parameters.AddWithValue("@descripcion", descripcion);
            da.UpdateCommand.Parameters.AddWithValue("@categoria", categoria);
            da.UpdateCommand.Parameters.AddWithValue("@proveedor", proveedor);
            da.UpdateCommand.Parameters.AddWithValue("@stock", stock);
            da.UpdateCommand.Parameters.AddWithValue("@stock_critico", stock_critico);
            da.UpdateCommand.Parameters.AddWithValue("@precio_venta", precio_venta);
            da.UpdateCommand.Parameters.AddWithValue("@precio_compra", precio_compra);
            da.UpdateCommand.Parameters.AddWithValue("@imagen", url);
            da.UpdateCommand.Parameters.AddWithValue("@codigo", codigo);
            da.UpdateCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void insertar_Producto(int codigo, string nombre,string descripcion,string categoria,string proveedor,int stock,int stock_critico,int precio_venta,int precio_compra,string url)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Producto(Cod_Producto,Nombre,Descripcion,Categoria,Proveedor,Stock,Stock_Critico,Precio_Venta,Precio_Compra,Url_Imagen) VALUES (@codigo,@nombre,@descripcion,@categoria,@proveedor,@stock,@stock_critico,@precio_venta,@precio_compra,@url);", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@codigo", codigo));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@categoria", categoria));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@proveedor", proveedor));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@stock", stock));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@stock_critico", stock_critico));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@precio_venta", precio_venta));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@precio_compra", precio_compra));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@url", url));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet rescata_producto(int codigo)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Producto where Cod_Producto=@codigo ", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@codigo", codigo));
            da.Fill(ds, "Producto");
            conn.desconectar();
            return ds;
        }
        public DataSet rescata_productos()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Producto", conn.conector);
            da.Fill(ds, "Producto");
            conn.desconectar();
            return ds;
        }
    }
}
