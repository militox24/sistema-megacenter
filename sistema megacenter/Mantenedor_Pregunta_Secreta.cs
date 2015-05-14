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
    public partial class Mantenedor_Pregunta_Secreta : Form
    {
        string respuestasecreta;
        string rutlogueo;
        string usuariologueado;
        public Mantenedor_Pregunta_Secreta(string pregunta,string respuesta,string rut,string usuario)
        {
            InitializeComponent();
            txtpreguntasecretarecupera.Text = pregunta;
            respuestasecreta = respuesta;
            rutlogueo = rut;
            usuariologueado = usuario;
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (txtrespuestarecupera.Text == "")
            {
                MessageBox.Show("Debes ingresar la respuesta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtrespuestarecupera.Text != respuestasecreta)
                {
                    MessageBox.Show("La respuesta ingresada no es correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    
                    Mantenedor_Cambio_Clave clave = new Mantenedor_Cambio_Clave(rutlogueo,usuariologueado);
                    clave.Show();

                }
            }
        }
    }
}
