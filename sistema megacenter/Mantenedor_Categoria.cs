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
    public partial class Mantenedor_Categoria : Form
    {
        string nombreusuario, apellidousuario, rutusuario, urlimagen;
        Gestion_Categoria gestion = new Gestion_Categoria();
        public Mantenedor_Categoria(string nombre, string apellido, string rut,string url)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
        }

        private void cargaagrecategoria_Click(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = true;
            gbelimcategoria.Visible = false;
            gbmodificacategoria.Visible = false;


        }

        private void Cargaelimcategoria_Click(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = false;
            gbelimcategoria.Visible = true;
            gbmodificacategoria.Visible = false;

        }

        private void cargamodicategoria_Click(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = false;
            gbelimcategoria.Visible = false;
            gbmodificacategoria.Visible = true;

        }
    }
}
