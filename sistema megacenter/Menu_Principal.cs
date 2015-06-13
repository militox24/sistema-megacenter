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
        string usuariologueado;
        public Menu_Principal(string nombres, string apellidos,string url,string rutcompleto,string usuario)
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
             usuariologueado = usuario;
        }

        private void btciudad_Click(object sender, EventArgs e)
        {
            Mantenedor_Ciudad ciudad = new Mantenedor_Ciudad(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            ciudad.Show();
        }

        private void btcategoria_Click(object sender, EventArgs e)
        {
            Mantenedor_Categoria categoria = new Mantenedor_Categoria(nombreusuario, apellidousuario, rutusuario, urlimagen);
            this.Hide();
            categoria.Show();
        }

        private void btperfil_Click(object sender, EventArgs e)
        {
            Mantenedor_Perfil perfil = new Mantenedor_Perfil(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            perfil.Show();
        }

        private void btproveedor_Click(object sender, EventArgs e)
        {
            Mantenedor_Proveedor proveedor = new Mantenedor_Proveedor(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            proveedor.Show();
        }

        private void btgiro_Click(object sender, EventArgs e)
        {
            Mantenedor_Giro giro = new Mantenedor_Giro(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            giro.Show();
        }

        private void btcliente_Click(object sender, EventArgs e)
        {
            Mantenedor_Cliente cliente = new Mantenedor_Cliente(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            cliente.Show();
        }

        private void btmulta_Click(object sender, EventArgs e)
        {
            Mantenedor_Multa multa = new Mantenedor_Multa(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            multa.Show();
        }

        private void btproducto_Click(object sender, EventArgs e)
        {
            Mantenedor_Producto producto = new Mantenedor_Producto(nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado);
            this.Hide();
            producto.Show();
        }

        private void btvendedor_Click(object sender, EventArgs e)
        {
            Mantenedor_Vendedor vendedor = new Mantenedor_Vendedor(nombreusuario, apellidousuario, rutusuario, urlimagen, usuariologueado);
            this.Hide();
            vendedor.Show();
        }

        private void btventa_Click(object sender, EventArgs e)
        {
            Mantenedor_Venta venta = new Mantenedor_Venta(nombreusuario, apellidousuario, rutusuario, urlimagen, usuariologueado);
            this.Hide();
            venta.Show();
        }

        private void btcompra_Click(object sender, EventArgs e)
        {
            Mantenedor_Compra compra = new Mantenedor_Compra(nombreusuario, apellidousuario, rutusuario, urlimagen, usuariologueado);
            compra.Hide();
            compra.Show();
        }

        

      



        
    }
}
