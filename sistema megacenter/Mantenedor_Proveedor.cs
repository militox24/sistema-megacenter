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
    public partial class Mantenedor_Proveedor : Form
    {
        string rutcompleto;
        Gestion_Proveedor gestion = new Gestion_Proveedor();
        VerificarRut rut = new VerificarRut();
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        Gestion_Giro giro = new Gestion_Giro();
        public Mantenedor_Proveedor()
        {
            InitializeComponent();
            cbciudadproveedoragrega.Text ="Seleccione";
            cbgiroproveedoragrega.Text = "Seleccione";
            DataSet ciudades = ciudad.rescatardatosciudades();
                for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
                {
                    cbciudadproveedoragrega.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
                }
                DataSet giros1 = giro.rescatar_giros();
                for (int i = 0; i < giros1.Tables["Giro"].Rows.Count; i++)
                {
                    cbgiroproveedoragrega.Items.Add(giros1.Tables["Giro"].Rows[i][0].ToString());
                }
        }

        private void btagregarproveedor_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            string errores="Usted tiene los siguientes errores:\n";
            if (txtrutproveedoragrega.Text == "" || txtdigitoproveedoragrega.Text == "" || txtnombreproveedoragrega.Text == "" || txtdescripcionproveedoragrega.Text == "" || txtdireccionagrega.Text == "" || txtemailproveedorsagrega.Text == "" || txturlproveedoragrega.Text == ""||cbciudadproveedoragrega.Text=="Seleccione"||cbgiroproveedoragrega.Text=="Seleccione")
            {
                errores = errores + "Debes completar todos los campos\n";
                estado = true;
            }
            if(txtdescripcionproveedoragrega.TextLength>150){
                errores = errores + "La descripcion debe tener menos de 150 caracteres\n";
                estado = true;
            }
            if(txtrutproveedoragrega.Text!="" && txtdigitoproveedoragrega.Text!=""){
              
                string digito=rut.digitoVerificador(int.Parse(txtrutproveedoragrega.Text));
                if (txtdigitoproveedoragrega.Text != digito)
                {
                    errores = errores + "El rut ingresado no es valido\n";
                    estado = true;
                }
                else
                {
                    rutcompleto = txtrutproveedoragrega.Text + "-" + txtdigitoproveedoragrega.Text;
                }
            }
           
            if(txtemailproveedorsagrega.Text!=""){
                Boolean correo = rut.email_bien_escrito(txtemailproveedorsagrega.Text);
                if (correo ==false)
                {
                    errores = errores + "La dirección de correo electrónico no es valida\n";
                    estado = true;
                }
               
            }
            
            if (estado == true)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificaproveedor = gestion.verificarexistenciaproveedor(rutcompleto);
                if (verificaproveedor.Tables["Proveedor"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un Proveedor registrado en el sistema ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gestion.ingresarproveedor(rutcompleto,txtnombreproveedoragrega.Text,txtdescripcionproveedoragrega.Text,txtdireccionagrega.Text,cbciudadproveedoragrega.Text,cbgiroproveedoragrega.Text,int.Parse(txttelefonoproveedoragrega.Text),txtemailproveedorsagrega.Text,txturlproveedoragrega.Text);
                    MessageBox.Show("Operación realizada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtrutproveedoragrega.Clear();
                    txtdigitoproveedoragrega.Clear();
                    txtnombreproveedoragrega.Clear();
                    txtdescripcionproveedoragrega.Clear();
                    txtdireccionagrega.Clear();
                    cbciudadproveedoragrega.SelectedIndex = -1;
                    cbgiroproveedoragrega.SelectedIndex = -1;
                    txttelefonoproveedoragrega.Clear();
                    txtemailproveedorsagrega.Clear();
                    txturlproveedoragrega.Clear();
                    
                    fotoproveedoragrega.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));
                }
            }

        }

        private void btexaminaragregarproveedor_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:/Users/kmilo";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txturlproveedoragrega.Text = abririmagen.FileName;
                fotoproveedoragrega.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoproveedoragrega.Image = (Image)imagen;

            }
        }
        private void omiitirCaracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890# " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtnombreproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omiitirCaracteres(sender,e);
        }
        private void txtdescripcionproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omiitirCaracteres(sender, e);
        }
        private void txtdireccionagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omiitirCaracteres(sender, e);
        }
        private void txtemailproveedorsagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omiitirCaracteres(sender, e);
        }

        private void txturlproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omiitirCaracteres(sender, e);
        }

        private void txtrutproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }
        private void solonumeros(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtdigitoproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txttelefonoproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void btagregagiro_Click(object sender, EventArgs e)
        {
            gbagregagiroproveedor.Visible = true;
            gbagregaproveedor.Visible=false;
        }
        private void btcargaagregaproveedor_Click(object sender, EventArgs e)
        {
            gbagregaciudadproveedor.Visible =false;
            gbagregagiroproveedor.Visible = false;
            gbagregaproveedor.Visible = true;
            gbeliminaproveedor.Visible = false;
            gbmodificaproveedor.Visible = false;
        }

        private void btcargaelimproveedor_Click(object sender, EventArgs e)
        {
            gbagregaciudadproveedor.Visible = false;
            gbagregagiroproveedor.Visible = false;
            gbagregaproveedor.Visible = false;
            gbeliminaproveedor.Visible = true;
            gbmodificaproveedor.Visible = false;
        }

        private void btcargamodificaproveedor_Click(object sender, EventArgs e)
        {
            gbagregaciudadproveedor.Visible = false;
            gbagregagiroproveedor.Visible = false;
            gbagregaproveedor.Visible = false;
            gbeliminaproveedor.Visible = false;
            gbmodificaproveedor.Visible = true;
        }

        private void btagregarciudadproveedor_Click(object sender, EventArgs e)
        {
            
            if (txtnombreciudadproveedor.Text == "" || txtdescripcionciudadproveedor.Text == "")
            {
                MessageBox.Show("Debes Ingresar los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = ciudad.verificarciudad(txtnombreciudadproveedor.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Actualmente se encuentra registrada esa ciudad en el sistema");
                    txtnombreciudadproveedor.Clear();
                    txtdescripcionciudadproveedor.Clear();
                }
                else
                {
                    ciudad.insertarCiudad(txtnombreciudadproveedor.Text, txtdescripcionciudadproveedor.Text);
                    MessageBox.Show("Operación realizada con exito");
                    txtnombreciudadproveedor.Clear();
                    txtdescripcionciudadproveedor.Clear();
                }
            }

        }

        private void txtdescripcionciudadproveedor_TextChanged(object sender, EventArgs e)
        {
            label25.Visible = true;
            label25.Text = txtdescripcionciudadproveedor.TextLength.ToString();
        }

        private void btagregaciudad_Click(object sender, EventArgs e)
        {
            
            gbagregaciudadproveedor.Visible = true;
            gbagregaproveedor.Visible = false;
        }

        private void btagregargiroproveedor_Click(object sender, EventArgs e)
        {
            string errores = "Usted tiene los siguientes errores:\n";
            Boolean estado = false;
            if (txtgiroagregaproveedor.Text == "" || txtdescripciongiroproveedor.Text == "")
            {
                errores = errores + "Debes completar todos los campos\n";
                estado = true;
            }
            if (txtgiroagregaproveedor.TextLength > 40)
            {
                errores = errores + "el giro debe contener menos de 40 carateres\n";
                estado = true;
            }
            if (txtdescripciongiroproveedor.TextLength > 150)
            {
                errores = errores + "La descripción debe contener menos de 150 carateres\n";
                estado = true;
            }
            if (estado != false)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificaexistencia = giro.verificar_giro(txtgiroagregaproveedor.Text);
                if (verificaexistencia.Tables["Giro"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un registro asociado con ese nombre de giro en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgiroagregaproveedor.Clear();
                    txtdescripciongiroproveedor.Clear();
                }
                else
                {
                    giro.registrar_giro(txtgiroagregaproveedor.Text, txtdescripciongiroproveedor.Text);
                    MessageBox.Show("Operación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgiroagregaproveedor.Clear();
                    txtdescripciongiroproveedor.Clear();



                }
            }
        }

        private void Btvolver_Click(object sender, EventArgs e)
        {
            DataSet giros = giro.rescatar_giros();
            cbgiroproveedoragrega.Items.Clear();
            cbgiroproveedoragrega.Items.Add("Seleccione");
            for (int i = 0; i < giros.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedoragrega.Items.Add(giros.Tables["Giro"].Rows[i][0].ToString());
            }
            gbagregagiroproveedor.Visible = false;
            gbagregaproveedor.Visible = true;
            
            
        }

        private void btvolver2_Click(object sender, EventArgs e)
        {
            DataSet ciudades = ciudad.rescatardatosciudades();
            cbciudadproveedoragrega.Items.Clear();
            cbciudadproveedoragrega.Items.Add("Seleccione");
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedoragrega.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudadproveedor.Visible = false;
            gbagregaproveedor.Visible = true;
        }

       

       

    }
}
