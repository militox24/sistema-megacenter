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
    public partial class Menu_Vendedor : Form
    {
        string nombreusuario;
        string apellidousuario;
        string urlimagen;
        string rutusuario;
        string usuariologueado;
        public Menu_Vendedor(string nombres,string apellidos,string url,string rutcompleto,string usuario)
        {
            InitializeComponent();
            label6.Text = nombres + " " + apellidos;
            label1.Text = DateTime.Now.ToString();
            fotoiniciovendedor.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + url + ""));
            fotoiniciovendedor.SizeMode = PictureBoxSizeMode.StretchImage;
            nombreusuario = nombres;
            apellidousuario = apellidos;
            urlimagen = url;
            usuariologueado = usuario;
            rutusuario = rutcompleto;

        }

        private void btHistorial_Click(object sender, EventArgs e)
        {
            Mantenedor_Historial_Multas historial = new Mantenedor_Historial_Multas(nombreusuario,apellidousuario,urlimagen,rutusuario);
            this.Hide();
            historial.Show();
        }

        private void btciudad_Click(object sender, EventArgs e)
        {
            Mantenedor_Ciudad ciudad = new Mantenedor_Ciudad(nombreusuario, apellidousuario, urlimagen, rutusuario,usuariologueado);
            this.Hide();
            ciudad.Show();
            
           
        }

        private void btclientevendedor_Click(object sender, EventArgs e)
        {
            Mantenedor_Cliente_Vendedor cliente = new Mantenedor_Cliente_Vendedor(nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado);
            this.Hide();
            cliente.Show();
        }

        private void btvendedor_Click(object sender, EventArgs e)
        {
            Mantenedor_Perfil_Vendedor perfil = new Mantenedor_Perfil_Vendedor(nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado);
            this.Hide();
            perfil.Show();
        }

        private void btcerrarsesionvendedor_Click(object sender, EventArgs e)
        {
            Interfaz_Inicial inicio = new Interfaz_Inicial();
            this.Hide();
            inicio.Show();
        }

        private void btventa_Click(object sender, EventArgs e)
        {
            Mantenedor_Venta venta = new Mantenedor_Venta(nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado);
            this.Hide();
            venta.Show();
        }

       

        
    }
}
