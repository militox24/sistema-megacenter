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
    public partial class Recupera_Contraseña_2 : Form
    {
        string preguntasecreta;
        string respuestasecreta;
        string rutlogueado;
        string correologueado;
        string usuariologueo;
        public Recupera_Contraseña_2(string pregunta, string respuesta, string correo, string rut,string usuario)
        {
            InitializeComponent();
            preguntasecreta = pregunta;
            respuestasecreta = respuesta;
            correologueado = correo;
            rutlogueado = rut;
            usuariologueo = usuario;

        }
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (Rbpreguntasecreta.Checked == false && Rbcorreoelectronico.Checked == false)
            {
                MessageBox.Show("Debes seleccionar una opción de recuperación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Rbpreguntasecreta.Checked == true)
                {
                    this.Close();
                    Mantenedor_Pregunta_Secreta pregunta = new Mantenedor_Pregunta_Secreta(preguntasecreta, respuestasecreta, rutlogueado,usuariologueo);
                    pregunta.Show();
                } if (Rbcorreoelectronico.Checked == true)
                {
                    this.Close();
                    string nombre = "Camilo Sebastian";
                    MessageBox.Show("¿NO PUEDES ACCEDER AL SISTEMA?\n Estimado(a):" + nombre + ",\n ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
