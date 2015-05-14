using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistema_megacenter
{
    public partial class Recupera_Contraseña : Form
    {
        public string usuariologueado;
        public Recupera_Contraseña(string usuario)
        {
            InitializeComponent();
            usuariologueado = usuario;
        }

        private void txtrutrecupera_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void btconsultarutrecupera_Click(object sender, EventArgs e)
        {
            if (txtrutrecupera.Text == "")
            {
                MessageBox.Show("Debes Ingresar el Rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gestion_Ingreso ingreso = new Gestion_Ingreso();
                DataSet ds1 = ingreso.Datos_recupera(txtrutrecupera.Text, usuariologueado);
                if (ds1.Tables["" + usuariologueado + ""].Rows.Count > 0)
                {
                    string pregunta = ds1.Tables["" + usuariologueado + ""].Rows[0][10].ToString();
                    string respuesta = ds1.Tables["" + usuariologueado + ""].Rows[0][11].ToString();
                    string correo = ds1.Tables["" + usuariologueado + ""].Rows[0][6].ToString();
                    string nombres = ds1.Tables["" + usuariologueado + ""].Rows[0][1].ToString() + " " + ds1.Tables["" + usuariologueado + ""].Rows[0][2].ToString(); ;
                    Recupera_Contraseña_2 recuperaclave = new Recupera_Contraseña_2(pregunta, respuesta, correo,txtrutrecupera.Text.ToString(),usuariologueado,nombres);
                    this.Close();
                    recuperaclave.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_Sistema ingreso = new Ingreso_Sistema(usuariologueado);
            ingreso.Show();
        }
    }
}
