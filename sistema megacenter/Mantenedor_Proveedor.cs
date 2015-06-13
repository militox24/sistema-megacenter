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
        Gestion_Proveedor proveedor = new Gestion_Proveedor();
        Gestion_Giro giro = new Gestion_Giro();
        string nonbreusuario, apellidosusuario, rutusuario, urlimagen,usuariologueado;
        public Mantenedor_Proveedor(string nombres,string apellidos,string rut,string url,string usuario)
        {
            InitializeComponent();
            nonbreusuario = nombres;
            apellidosusuario = apellidos;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
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
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txturlproveedoragrega.Text = abririmagen.FileName;
                fotoproveedoragrega.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoproveedoragrega.Image = (Image)imagen;

            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtnombreproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }
        private void txtdescripcionproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }
        private void txtdireccionagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }
        private void txtemailproveedorsagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txturlproveedoragrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
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
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaeliminarproveedor.RowCount; i++)
            {
                grillaeliminarproveedor[1, i].ReadOnly = true;
                grillaeliminarproveedor[2, i].ReadOnly = true;
                grillaeliminarproveedor[3, i].ReadOnly = true;
                grillaeliminarproveedor[4, i].ReadOnly = true;
                grillaeliminarproveedor[5, i].ReadOnly = true;
                grillaeliminarproveedor[6, i].ReadOnly = true;
                grillaeliminarproveedor[7, i].ReadOnly = true;
                grillaeliminarproveedor[8, i].ReadOnly = true;
                grillaeliminarproveedor[9, i].ReadOnly = true;
                grillaeliminarproveedor[0, i].Value = false;
                grillaeliminarproveedor[0, i].ReadOnly = false;
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
            Btvolver.Visible = true;
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
            grillaeliminarproveedor.DataSource = proveedor.rescatartodoslosproveedores();
            grillaeliminarproveedor.DataMember = "Proveedor";
            grillaeliminarproveedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Url"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Nombres"].Width = 150;
            grillaeliminarproveedor.Columns["Descripcion"].Width = 200;
            grillaeliminarproveedor.Columns["Giro"].Width = 200;
            grillaeliminarproveedor.Columns["Email"].Width = 250;
            grillaeliminarproveedor.Columns["Url"].Width = 300;
            inicializarCheckbox();

        }

        private void btcargamodificaproveedor_Click(object sender, EventArgs e)
        {
            gbagregaciudadproveedor.Visible = false;
            gbagregagiroproveedor.Visible = false;
            gbagregaproveedor.Visible = false;
            gbeliminaproveedor.Visible = false;
            gbmodificaproveedor.Visible = true;
            cbciudadproveedormodifica.Text = "Seleccione";
            cbgiroproveedormodifica.Text = "Seleccione";
            DataSet dsgiro = giro.rescatar_giros();
            for (int i = 0; i < dsgiro.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedormodifica.Items.Add(dsgiro.Tables["Giro"].Rows[i][0].ToString());
            }
            DataSet dsciudad = ciudad.rescatardatosciudades();
            for (int i = 0; i < dsciudad.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedormodifica.Items.Add(dsciudad.Tables["Ciudad"].Rows[i][0].ToString());
            }

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
            btvolver2.Visible = true;
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
            cbgiroproveedoragrega.Text = "Seleccione";
            
            
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
            cbciudadproveedoragrega.Text = "Seleccione";
        }

        private void btbuscarproveedoreliminar_Click(object sender, EventArgs e)
        {
            if (txtrutproveedoreliminar.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del proveedor a eliminar");
            }
            else
            {
                DataSet ds = proveedor.Buscar_Proveedor(txtrutproveedoreliminar.Text);
                if (ds.Tables["Proveedor"].Rows.Count > 0)
                {
                    grillaeliminarproveedor.DataSource = proveedor.Buscar_Proveedor(txtrutproveedoreliminar.Text);
                    grillaeliminarproveedor.DataMember = "Proveedor";
                    grillaeliminarproveedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Url"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproveedor.Columns["Nombres"].Width = 150;
                    grillaeliminarproveedor.Columns["Descripcion"].Width = 200;
                    grillaeliminarproveedor.Columns["Giro"].Width = 200;
                    grillaeliminarproveedor.Columns["Email"].Width = 250;
                    grillaeliminarproveedor.Columns["Url"].Width = 300;
                    inicializarCheckbox();
                    
                }
                else
                {
                    MessageBox.Show("No existe un proveedor registrado con ese rut en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void beliminarproveedor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grillaeliminarproveedor.RowCount; i++)
            {
                if (grillaeliminarproveedor[0, i].Value.ToString() == "true")
                {
                    gestion.Eliminar_Proveedor(grillaeliminarproveedor[1, i].Value.ToString());
                }
            }
            MessageBox.Show("Proveedor Eliminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grillaeliminarproveedor.DataSource = proveedor.rescatartodoslosproveedores();
            grillaeliminarproveedor.DataMember = "Proveedor";
            grillaeliminarproveedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Url"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproveedor.Columns["Nombres"].Width = 150;
            grillaeliminarproveedor.Columns["Descripcion"].Width = 200;
            grillaeliminarproveedor.Columns["Giro"].Width = 200;
            grillaeliminarproveedor.Columns["Email"].Width = 250;
            grillaeliminarproveedor.Columns["Url"].Width = 300;
            inicializarCheckbox();
        }

        private void btcancelarmodificarproveedor_Click(object sender, EventArgs e)
        {
            txtrutmodificaproveedor.Enabled = true;
            txtrutmodificaproveedor.Clear();
            txtnombreproveedormodifica.Clear();
            txtdescripcionproveedormodifica.Clear();
            txtdireccionproveedormodifica.Clear();
            cbciudadproveedormodifica.SelectedIndex = -1;
            cbgiroproveedormodifica.SelectedIndex = -1;
            txttelefonoproveedormodifica.Clear();
            btexaminarproveedormodifica.Visible = false;
            txtemailproveedormodifica.Clear();
            txturlproveedormodifica.Clear();
            fotoproveedormodifica.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));
        }

        private void btbuscarproveedormodifica_Click(object sender, EventArgs e)
        {
            DataSet ds = proveedor.Buscar_Proveedor(txtrutmodificaproveedor.Text);
            if (ds.Tables["Proveedor"].Rows.Count > 0)
            {
                txtrutmodificaproveedor.Enabled = false;
                txtnombreproveedormodifica.Enabled = true;
                txtdescripcionproveedormodifica.Enabled = true;
                cbciudadproveedormodifica.Enabled = true;
                cbgiroproveedormodifica.Enabled = true;
                txtdireccionproveedormodifica.Enabled = true;
                txttelefonoproveedormodifica.Enabled = true;
                txtemailproveedormodifica.Enabled = true;
                txturlproveedormodifica.Enabled = true;
                btexaminarproveedormodifica.Visible = true;
                txtnombreproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][1].ToString();
                txtdescripcionproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][2].ToString();
                txtdireccionproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][3].ToString();
                cbciudadproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][4].ToString();
                cbgiroproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][5].ToString();
                txttelefonoproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][6].ToString();
                txtemailproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][7].ToString();
                txturlproveedormodifica.Text = ds.Tables["Proveedor"].Rows[0][8].ToString();
                fotoproveedormodifica.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + txturlproveedormodifica.Text+ ""));
                fotoproveedormodifica.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                MessageBox.Show("No existe un proveedor registrado con ese rut en el sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btciudadproveedormodifica_Click(object sender, EventArgs e)
        {
            gbagregaciudadproveedor.Visible = true;
            gbmodificaproveedor.Visible = false;
            btvolverproveedormodifica.Visible = true;
            
        }

        private void btvolverproveedormodifica_Click(object sender, EventArgs e)
        {
            DataSet ciudadproveedormodifica = ciudad.rescatardatosciudades();
            cbciudadproveedormodifica.Items.Clear();
            cbciudadproveedormodifica.Items.Add("Seleccione");
            for (int i = 0; i < ciudadproveedormodifica.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedormodifica.Items.Add(ciudadproveedormodifica.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudadproveedor.Visible = false;
            gbmodificaproveedor.Visible = true;
            cbciudadproveedormodifica.Text = "Seleccione";
        }

        private void btvolverproveedormodifica2_Click(object sender, EventArgs e)
        {
            DataSet giroproveedormodifica = giro.rescatar_giros();
            cbgiroproveedormodifica.Items.Clear();
            cbgiroproveedormodifica.Items.Add("Seleccione");
            for (int i = 0; i < giroproveedormodifica.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedormodifica.Items.Add(giroproveedormodifica.Tables["Giro"].Rows[i][0].ToString());
            }
            gbagregagiroproveedor.Visible = false;
            gbmodificaproveedor.Visible = true;
            cbgiroproveedormodifica.Text ="Seleccione";
        }

        private void btgiroproveedormodifica_Click(object sender, EventArgs e)
        {
            gbagregagiroproveedor.Visible = true;
            gbmodificaproveedor.Visible = false;
            btvolverproveedormodifica2.Visible = true;
        }

        private void btmodificarproveedor_Click(object sender, EventArgs e)
        {
            if (txtnombreproveedormodifica.Text == "" || txtdescripcionproveedormodifica.Text == "" || txtdireccionproveedormodifica.Text == "" || cbciudadproveedormodifica.Text == "Seleccione" || cbgiroproveedormodifica.Text == "Seleccione" || txttelefonoproveedormodifica.Text == "" || txtemailproveedormodifica.Text == "" || txturlproveedormodifica.Text == "")
            {
                MessageBox.Show("Debes ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                proveedor.modificadatosproveedor(txtrutmodificaproveedor.Text, txtnombreproveedormodifica.Text, txtdescripcionproveedormodifica.Text, txtdireccionproveedormodifica.Text, cbciudadproveedormodifica.Text, cbgiroproveedormodifica.Text, int.Parse(txttelefonoproveedormodifica.Text), txtemailproveedormodifica.Text, txturlproveedormodifica.Text);
                MessageBox.Show("Operacion realizada con exito","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtrutmodificaproveedor.Clear();
                txtnombreproveedormodifica.Clear();
                txtdescripcionproveedormodifica.Clear();
                txtdireccionproveedormodifica.Clear();
                cbciudadproveedormodifica.SelectedIndex = -1;
                cbgiroproveedormodifica.SelectedIndex = -1;
                txttelefonoproveedormodifica.Clear();
                txtemailproveedormodifica.Clear();
                txturlproveedormodifica.Clear();
                fotoproveedormodifica.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));
                txtnombreproveedormodifica.Enabled = false;
                txtdescripcionproveedormodifica.Enabled = false;
                txtdireccionproveedormodifica.Enabled = false;
                cbciudadproveedormodifica.Enabled = false;
                cbgiroproveedormodifica.Enabled = false;
                txttelefonoproveedormodifica.Enabled = false;
                txtemailproveedormodifica.Enabled = false;
                txturlproveedormodifica.Enabled = false;
                btexaminarproveedormodifica.Visible = false;
            }
        }

        private void btexaminarproveedormodifica_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txturlproveedormodifica.Text = abririmagen.FileName;
                fotoproveedormodifica.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoproveedormodifica.Image = (Image)imagen;

            }
        }

        private void txtdescripciongiroproveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripciongiroproveedor.Text != "")
            {
                label21.Visible = true;
                label21.Text = txtdescripciongiroproveedor.TextLength.ToString();
            }
            else
            {
                label21.Visible = false;
            }
            

        }

        private void txtrutmodificaproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtnombreproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdescripcionproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdireccionproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtemailproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txttelefonoproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        private void txturlproveedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void btvolvermenuprincipal1_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nonbreusuario,apellidosusuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();
        }
    }
}
