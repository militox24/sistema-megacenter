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
    public partial class Mantenedor_Perfil : Form
    {
        Gestion_perfil perfil = new Gestion_perfil();
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        string nombreusuario,apellidousuario,imagenusuario,rutuusuario,usuariologueado;
        public Mantenedor_Perfil(string nombres,string apellidos,string url,string rut,string usuario)
        {
            InitializeComponent();
            DataSet rescata = perfil.Rescatar_datos(rut);
            DataSet ciudades = ciudad.rescatardatosciudades();
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadperfil.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
            txtrutperfil.Text = rut;
            txtnombresperfil.Text = rescata.Tables["Administrador"].Rows[0][1].ToString();
            txtapellidosperfil.Text = rescata.Tables["Administrador"].Rows[0][2].ToString();
            cbsexoperfil.Text = rescata.Tables["Administrador"].Rows[0][3].ToString();
            txtdireccionperfil.Text = rescata.Tables["Administrador"].Rows[0][4].ToString();
            cbciudadperfil.Text = rescata.Tables["Administrador"].Rows[0][5].ToString();
            txtcorreoperfil.Text = rescata.Tables["Administrador"].Rows[0][6].ToString();
            txtclaveperfil.Text = rescata.Tables["Administrador"].Rows[0][7].ToString();
            txtpreguntaperfil.Text = rescata.Tables["Administrador"].Rows[0][8].ToString();
            txtrespuestaperfil.Text = rescata.Tables["Administrador"].Rows[0][9].ToString();
            txttelefonoperfil.Text = rescata.Tables["Administrador"].Rows[0][10].ToString();
            txtimagenperfil.Text = rescata.Tables["Administrador"].Rows[0][11].ToString();
            fotoadministradorperfil.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + txtimagenperfil.Text + ""));
            fotoadministradorperfil.SizeMode = PictureBoxSizeMode.StretchImage;
            nombreusuario = nombres;
            apellidousuario = apellidos;
            imagenusuario = url;
            rutuusuario = rut;
            usuariologueado = usuario;



        }

        private void btexaminarperfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtimagenperfil.Text = abririmagen.FileName;
                fotoadministradorperfil.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoadministradorperfil.Image = (Image)imagen;
            }
        }

        private void txtdescripcionciudadperfil_TextChanged(object sender, EventArgs e)
        {
            label25.Visible = true;
            label25.Text = txtdescripcionciudadperfil.TextLength.ToString();
        }

        private void btagregarciudadperfil_Click(object sender, EventArgs e)
        {
            if (txtnombreciudadperfil.Text == "" || txtdescripcionciudadperfil.Text == "")
            {
                MessageBox.Show("Debes Ingresar los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = ciudad.verificarciudad(txtnombreciudadperfil.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Actualmente se encuentra registrada esa ciudad en el sistema");
                    txtnombreciudadperfil.Clear();
                    txtdescripcionciudadperfil.Clear();
                }
                else
                {
                    ciudad.insertarCiudad(txtnombreciudadperfil.Text, txtdescripcionciudadperfil.Text);
                    MessageBox.Show("Operación realizada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtnombreciudadperfil.Clear();
                    txtdescripcionciudadperfil.Clear();
                }
            }
        }

        private void txttelefonoperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnombresperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtapellidosperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdireccionperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtcorreoperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtclaveperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtpreguntaperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtrespuestaperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtimagenperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtnombreciudadperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdescripcionciudadperfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void btvolverperfil_Click(object sender, EventArgs e)
        {
            DataSet rescataciudad = ciudad.rescatardatosciudades();
            cbciudadperfil.Items.Clear();
            cbciudadperfil.Items.Add("Seleccione");
            for (int i = 0; i < rescataciudad.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadperfil.Items.Add(rescataciudad.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudadperfil.Visible = false;
            gbperfiladministrador.Visible = true;
            cbciudadperfil.Text = "Seleccione";
        }

        private void btagregaciudadperfil_Click(object sender, EventArgs e)
        {
            gbagregaciudadperfil.Visible = true;
            gbperfiladministrador.Visible = false;
        }

        private void btmodificarperfil_Click(object sender, EventArgs e)
        {
            if (txtnombresperfil.Text == "" || txtapellidosperfil.Text == "" || cbsexoperfil.Text == "Seleccione" || txtdireccionperfil.Text == "" || cbciudadperfil.Text == "" || txtcorreoperfil.Text == "" || txtclaveperfil.Text == "" || txtpreguntaperfil.Text == "" || txtrespuestaperfil.Text == "" || txttelefonoperfil.Text == "" || txtimagenperfil.Text == "")
            {
                MessageBox.Show("Debes ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                perfil.modificadatosperfil(txtrutperfil.Text,txtnombresperfil.Text,txtapellidosperfil.Text,cbsexoperfil.Text,txtdireccionperfil.Text,cbciudadperfil.Text,txtcorreoperfil.Text,txtclaveperfil.Text,txtpreguntaperfil.Text,txtrespuestaperfil.Text,int.Parse(txttelefonoperfil.Text),txtimagenperfil.Text);
                MessageBox.Show("Modificacion realizada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btvolvermenuprincipal_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(txtnombresperfil.Text,txtapellidosperfil.Text,txtimagenperfil.Text,txtrutperfil.Text,usuariologueado);
            this.Hide();
            principal.Show();
        }
    }
}
