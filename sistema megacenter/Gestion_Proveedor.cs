using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sistema_megacenter
{
    class Gestion_Proveedor
    {
        Conexion conn = new Conexion();
        public DataSet verificarexistenciaproveedor(string rut)
        {
            conn.conectar();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Proveedor where Rut=@rut", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@rut", rut));
            da.Fill(ds, "Proveedor");
            conn.desconectar();
            return ds;
        }
        public void ingresarproveedor(string rut, string nombre,string descripcion,string direccion,string ciudad,string giro,int telefono,string email,string url)
        {
            conn.conectar();
            SqlDataAdapter dd = new SqlDataAdapter();
            dd.InsertCommand = new SqlCommand("INSERT INTO Proveedor(Rut,Nombres,Descripcion,Dirección,Ciudad,Giro,Telefono,Email,Url) VALUES (@rut,@nombre,@descripcion,@direccion,@ciudad,@giro,@telefono,@email,@url );", conn.conector);
            dd.InsertCommand.Parameters.Add(new SqlParameter("@rut", rut));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", descripcion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@direccion", direccion));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@ciudad", ciudad));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@giro", giro));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@telefono", telefono));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@email", email));
            dd.InsertCommand.Parameters.Add(new SqlParameter("@url", url));
            dd.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
    }
}
