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
    public partial class Mantenedor_Perfil_Vendedor : Form
    {
        Gestion_Vendedor vendedor = new Gestion_Vendedor();
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        string nombreusuario, apellidousuario, imagenusuario, rutusuario, usuariologueado,correologueado;
        public Mantenedor_Perfil_Vendedor(string nombre,string apellido,string url,string rut,string usuario,string correo)
        {
            InitializeComponent();
            DataSet ciudades = ciudad.rescatardatosciudades();
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadvendedorperfil.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
            txtrutvendedorperfil.Text = rut;
            DataSet rescata = vendedor.verificarexistencia(txtrutvendedorperfil.Text);
            txtnombrevendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][1].ToString();
            txtapellidovendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][2].ToString();
            txttelefonovendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][3].ToString();
            txtdireccionvendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][4].ToString();
            cbciudadvendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][5].ToString();
            fechanacimientovendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][9].ToString();
            txtpreguntavendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][10].ToString();
            txtrespuestavendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][11].ToString();
            txtclavevendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][7].ToString();
            txtemailvendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][6].ToString();
            txtimagenvendedorperfil.Text = rescata.Tables["Vendedor"].Rows[0][13].ToString();
            fotovendedorperfil.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + txtimagenvendedorperfil.Text + ""));
            fotovendedorperfil.SizeMode = PictureBoxSizeMode.StretchImage;
            nombreusuario = nombre;
            apellidousuario = apellido;
            imagenusuario = url;
            rutusuario = rut;
            usuariologueado = usuario;
        }

        private void btexaminarperfilvendedor_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtimagenvendedorperfil.Text = abririmagen.FileName;
                fotovendedorperfil.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotovendedorperfil.Image = (Image)imagen;
            }
        }

        private void btmodificarvendedorperfil_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            string errores = "Usted tiene los siguientes errores\n";
            if (txtnombrevendedorperfil.Text == "" || txtapellidovendedorperfil.Text == "" || txttelefonovendedorperfil.Text == "" || txtdireccionvendedorperfil.Text == "" || cbciudadvendedorperfil.Text == "Seleccione" || txtpreguntavendedorperfil.Text == "" || txtrespuestavendedorperfil.Text == "" || txtclavevendedorperfil.Text == "" || txtemailvendedorperfil.Text == "" || txtimagenvendedorperfil.Text == "")
            {
                errores = errores + "Debes ingresar todos los campos\n";
                estado = true;
            }
            if (txtemailvendedorperfil.Text != "")
            {
                VerificarRut verificar = new VerificarRut();
                Boolean correo = verificar.email_bien_escrito(txtemailvendedorperfil.Text);
                if (correo == false)
                {
                    errores = errores + "Debes ingresar una direccion de email valida\n";
                    estado = true;
                }
            }
            if (estado == true)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vendedor.modificar_vendedor_perfil(txtrutvendedorperfil.Text, txtnombrevendedorperfil.Text, txtapellidovendedorperfil.Text, int.Parse(txttelefonovendedorperfil.Text), txtdireccionvendedorperfil.Text, cbciudadvendedorperfil.Text, fechanacimientovendedorperfil.Value.ToShortDateString(), txtpreguntavendedorperfil.Text, txtrespuestavendedorperfil.Text, txtclavevendedorperfil.Text,  txtemailvendedorperfil.Text, txtimagenvendedorperfil.Text);
                MessageBox.Show("Modificación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btvolvermenuprincipalvendedorp_Click(object sender, EventArgs e)
        {
            Menu_Vendedor principal = new Menu_Vendedor(nombreusuario,apellidousuario,imagenusuario,rutusuario,usuariologueado,txtemailvendedorperfil.Text);
            this.Hide();
            principal.Show();
        }

        private void txtnombrevendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender ,e);
        }

        private void txtapellidovendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdireccionvendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtpreguntavendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtrespuestavendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtclavevendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtemailvendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:.1234567890 " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefonovendedorperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
