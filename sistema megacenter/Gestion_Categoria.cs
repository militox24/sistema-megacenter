using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//importar 
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;//para el dataset
using System.Text.RegularExpressions;

namespace sistema_megacenter
{
    class Gestion_Categoria
    {
        Conexion conn = new Conexion();
        public DataSet verificarcategoria(string nombre_categoria)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Categoria where Nombre_Categoria=@nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@nombre", nombre_categoria));
            da.Fill(ds, "Categoria");
            conn.desconectar();
            return ds;
        }
        public void insertarCategoria(string nombre, string descripcion)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Categoria(Nombre_Categoria,Descripción) VALUES (@nombre,@descripcion);", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public DataSet rescatardatoscategorias()
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Nombre_Categoria,Descripción from Categoria", conn.conector);
            da.Fill(ds, "Categoria");
            conn.desconectar();
            return ds;
        }
        public void Eliminar_Categoria(string nombre)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.DeleteCommand = new SqlCommand("Delete from Categoria where Nombre_Categoria=@nombre", conn.conector);
            dd.DeleteCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            dd.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();
        }

    }
}
