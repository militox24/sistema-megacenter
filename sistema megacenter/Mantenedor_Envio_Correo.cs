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
    public partial class Mantenedor_Envio_Correo : Form
    {
        string usuariologueado;
        public Mantenedor_Envio_Correo(string correologueado,string usuario)
        {
            InitializeComponent();
            label5.Text = correologueado;
            usuariologueado = usuario;
        }

        private void BtAceptarmensaje_Click(object sender, EventArgs e)
        {
            Ingreso_Sistema ingreso = new Ingreso_Sistema(usuariologueado);
            this.Close();
            ingreso.Show();
        }
    }
}
