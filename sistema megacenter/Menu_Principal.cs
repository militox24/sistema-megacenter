using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sistema_megacenter
{
    public partial class Menu_Principal : Form
    {
        string nombreusuario;
        string apellidousuario;
        string urlimagen;
        string rutusuario;
        public Menu_Principal(string nombres, string apellidos,string url,string rutcompleto)
        {
            InitializeComponent();
            label6.Text = nombres + " " + apellidos;
            label1.Text = DateTime.Now.ToString();
            fotoinicioadministrador.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + url + ""));
            fotoinicioadministrador.SizeMode = PictureBoxSizeMode.StretchImage;
            nombreusuario = nombres;
             apellidousuario = apellidos;
             urlimagen = url;
             rutusuario = rutcompleto;
        }

        private void btciudad_Click(object sender, EventArgs e)
        {
            Mantenedor_Ciudad ciudad = new Mantenedor_Ciudad(nombreusuario, apellidousuario, rutusuario, urlimagen);
            this.Hide();
            ciudad.Show();
        }

        private void btcategoria_Click(object sender, EventArgs e)
        {
            Mantenedor_Categoria categoria = new Mantenedor_Categoria(nombreusuario, apellidousuario, rutusuario, urlimagen);
            this.Hide();
            categoria.Show();
        }

        
    }
}
