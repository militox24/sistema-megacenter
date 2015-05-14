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
    public partial class Interfaz_Inicial : Form
    {
        public string logueo;
        public Interfaz_Inicial()
        {
            InitializeComponent();

        }

        private void btacessadministrador_Click(object sender, EventArgs e)
        {
            logueo = "Administrador";
            this.Hide();
            Ingreso_Sistema ingreso = new Ingreso_Sistema(logueo);
            ingreso.Show();
        }

        private void Btacessvendedor_Click(object sender, EventArgs e)
        {
            logueo = "Vendedor";
            this.Hide();
            Ingreso_Sistema ingreso = new Ingreso_Sistema(logueo);
            ingreso.Show();
        }
    }
}
