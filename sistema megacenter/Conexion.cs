using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_megacenter
{
    class Conexion
    {
        private string cadena = "Data Source=KMILO-PC; Initial Catalog=Tienda; Integrated Security=true";
        private SqlConnection conn;
        public void conectar()
        {
            try
            {
                conn = new SqlConnection(cadena);
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn = null;
            }
        }
        public void desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn = null;
                MessageBox.Show(ex.Message);
            }
        }
        public SqlConnection conector
        {
            set { }
            get { return conn; }
        }
    }
}
