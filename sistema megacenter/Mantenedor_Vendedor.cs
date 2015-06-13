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
    public partial class Mantenedor_Vendedor : Form
    {
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        VerificarRut verificar = new VerificarRut();
        Gestion_Vendedor vendedor = new Gestion_Vendedor();
        string rutcompleto;
        string nombreusuario, apellidousuario, rutusuario, urlimagen, usuariologueado;
        public Mantenedor_Vendedor(string nombre,string apellido,string rut,string url,string usuario)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
            cbciudadagrevende.Text = "Seleccione";
            DataSet ciudades = ciudad.rescatardatosciudades();
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadagrevende.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
            
        }

        private void btexaminaragregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtimagenvendedor.Text = abririmagen.FileName;
                fotovendedor.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotovendedor.Image = (Image)imagen;

            }
        }

        private void btcargaagregavendedor_Click(object sender, EventArgs e)
        {
            gbagregavendedor.Visible = true;
            gbeliminavendedor.Visible = false;
            gbmodificavendedor.Visible = false;

        }

        private void btcargareliminavendedor_Click(object sender, EventArgs e)
        {
            gbagregavendedor.Visible = false;
            gbeliminavendedor.Visible = true;
            gbmodificavendedor.Visible = false;
            GrillaElimVendedor.DataSource = vendedor.rescatardatosvendedor();
            GrillaElimVendedor.DataMember = "Vendedor";
            GrillaElimVendedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Nombres"].Width = 150;
            GrillaElimVendedor.Columns["Apellidos"].Width = 200;
            GrillaElimVendedor.Columns["Correo"].Width = 250;
            inicializarCheckbox();


        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < GrillaElimVendedor.RowCount; i++)
            {
                GrillaElimVendedor[1, i].ReadOnly = true;
                GrillaElimVendedor[2, i].ReadOnly = true;
                GrillaElimVendedor[3, i].ReadOnly = true;
                GrillaElimVendedor[4, i].ReadOnly = true;
                GrillaElimVendedor[5, i].ReadOnly = true;
                GrillaElimVendedor[0, i].Value = false;
                GrillaElimVendedor[0, i].ReadOnly = false;
            }
        }

        private void btcargamodificavendedor_Click(object sender, EventArgs e)
        {
            gbagregavendedor.Visible = false;
            gbeliminavendedor.Visible = false;
            gbmodificavendedor.Visible = true;
            DataSet ciudades = ciudad.rescatardatosciudades();
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadvendedormodifica.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
        }
        private void solonumeros(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú@. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrutvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        private void txtdigitovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtnombrevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtapellidovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txttelefonovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        private void txtdireccionvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtpreguntasecretavendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtrespuestavendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtclavevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtemailvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtsueldovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender, e);
        }

        private void txtimagenvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void btagregarvendedor_Click(object sender, EventArgs e)
        {
            Boolean estado=false;
            string errores="Usted tiene los siguientes errores:\n";
            if(txtrutvendedor.Text==""||txtdigitovendedor.Text==""||txtnombrevendedor.Text==""||txtapellidovendedor.Text==""||txttelefonovendedor.Text==""||cbciudadagrevende.Text=="Seleccione"||txtemailvendedor.Text==""||txtclavevendedor.Text==""||txtpreguntasecretavendedor.Text==""||txtrespuestavendedor.Text==""||txtsueldovendedor.Text==""||txtimagenvendedor.Text==""){
                errores = errores + "Debes ingresar todos los campos\n";
                estado=true;
            }
            if(txtrutvendedor.Text!="" ||txtdigitovendedor.Text!=""){
               string digito = verificar.digitoVerificador(int.Parse(txtrutvendedor.Text));
               if (txtdigitovendedor.Text != digito)
               {
                   errores = errores + "El rut ingresado no es valido\n";
                   estado = true;
               }
               else
               {
                   rutcompleto = txtrutvendedor.Text + "-" + txtdigitovendedor.Text;
               }
            }
            if (Fechanacimientovendedor.Value.ToShortDateString() ==DateTime.Now.ToShortDateString())
            {
                errores = errores + "Debes ingresar la fecha de nacimiento\n";
                estado = true;
            }
            if (txtemailvendedor.Text != "")
            {
                Boolean correo = verificar.email_bien_escrito(txtemailvendedor.Text);
                if (correo == false)
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
                DataSet verifica = vendedor.verificarexistencia(rutcompleto);
                if (verifica.Tables["Vendedor"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un vendedor registrado con ese rut en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reiniciar_mantenedoragregarvendedor();
                }
                else
                {
                    string fecha_ingreso=DateTime.Now.ToShortDateString();
                    vendedor.AgregarVendedor(rutcompleto,txtnombrevendedor.Text,txtapellidovendedor.Text,int.Parse(txttelefonovendedor.Text),txtdireccionvendedor.Text,cbciudadagrevende.Text,txtemailvendedor.Text,txtclavevendedor.Text,fecha_ingreso,Fechanacimientovendedor.Value.ToShortDateString(),txtpreguntasecretavendedor.Text,txtrespuestavendedor.Text,int.Parse(txtsueldovendedor.Text),txtimagenvendedor.Text);
                    MessageBox.Show("Operación realizada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    reiniciar_mantenedoragregarvendedor();
                }
            }
            

        }
        private void reiniciar_mantenedoragregarvendedor(){
            txtrutvendedor.Clear();
            txtdigitovendedor.Clear();
            txtnombrevendedor.Clear();
            txtnombrevendedor.Clear();
            txtapellidovendedor.Clear();
            txttelefonovendedor.Clear();
            txtdireccionvendedor.Clear();
            cbciudadagrevende.SelectedIndex = -1;
            txtpreguntasecretavendedor.Clear();
            txtrespuestavendedor.Clear();
            txtclavevendedor.Clear();
            txtemailvendedor.Clear();
            txtsueldovendedor.Clear();
            txtimagenvendedor.Clear();
            fotovendedor.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));

        }

        private void btbuscarvendelim_Click(object sender, EventArgs e)
        {
            if (txtrutelimvendedor.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del vendedor a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GrillaElimVendedor.DataSource = vendedor.verificarexistencia(txtrutelimvendedor.Text);
                GrillaElimVendedor.DataMember = "Vendedor";
                GrillaElimVendedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                GrillaElimVendedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                GrillaElimVendedor.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                GrillaElimVendedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
                GrillaElimVendedor.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                GrillaElimVendedor.Columns["Nombres"].Width = 150;
                GrillaElimVendedor.Columns["Apellidos"].Width = 200;
                GrillaElimVendedor.Columns["Correo"].Width = 250;
                inicializarCheckbox();
                txtrutelimvendedor.Clear();
            }
        }

        private void btelimvendedor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GrillaElimVendedor.RowCount; i++)
            {
                if (GrillaElimVendedor[0, i].Value.ToString() == "true")
                {
                    vendedor.Eliminar_Vendedor(GrillaElimVendedor[1, i].Value.ToString());
                }
            }
            MessageBox.Show("Vendedor Eliminado Correctamente");
            GrillaElimVendedor.DataSource = vendedor.rescatardatosvendedor();
            GrillaElimVendedor.DataMember = "Vendedor";
            GrillaElimVendedor.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Dirección"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaElimVendedor.Columns["Nombres"].Width = 150;
            GrillaElimVendedor.Columns["Apellidos"].Width = 200;
            GrillaElimVendedor.Columns["Correo"].Width = 250;
            inicializarCheckbox();
            
        }
        private void btbuscarvendedormodifica_Click(object sender, EventArgs e)
        {
            if (txtrutmodven.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del vendedor a buscar");
            }
            else
            {
                DataSet verificaexistenciavendedor = vendedor.verificarexistencia(txtrutmodven.Text);
                if (verificaexistenciavendedor.Tables["Vendedor"].Rows.Count > 0)
                {
                    debloquearcamposbuscarmodifica();
                    txtnombrevendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][1].ToString();
                    txtapellidovendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][2].ToString();
                    txttelefonovendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][3].ToString();
                    txtdireccionvendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][4].ToString();
                    cbciudadvendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][5].ToString();
                    fechanacimientovendedormodifica.Text=verificaexistenciavendedor.Tables["Vendedor"].Rows[0][9].ToString();
                    txtpreguntavendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][10].ToString();
                    txtrespuestavendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][11].ToString();
                    txtclavevendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][7].ToString();
                    txtsueldovendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][12].ToString();
                    txtemailvendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][6].ToString();
                    txtimagenvendedormodifica.Text = verificaexistenciavendedor.Tables["Vendedor"].Rows[0][13].ToString();
                    fotovendedormodifica.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + txtimagenvendedormodifica.Text + ""));
                    fotovendedormodifica.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("No existe ningun registro con ese rut en el sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cancelarmodificacion();
                }
            }
        }

        private void btmodificarvendedor_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            string errores = "Usted tiene los siguientes errores\n";
            if (txtnombrevendedormodifica.Text == "" || txtapellidovendedormodifica.Text == "" || txttelefonovendedormodifica.Text == "" || txtdireccionvendedormodifica.Text == "" || cbciudadvendedormodifica.Text == "Seleccione" || txtpreguntavendedormodifica.Text == "" || txtrespuestavendedormodifica.Text == "" || txtclavevendedormodifica.Text == "" || txtsueldovendedormodifica.Text == "" || txtemailvendedormodifica.Text == "" || txtimagenvendedormodifica.Text == "")
            {
                errores = errores + "Debes ingresar todos los campos\n";
                estado = true;
            }
                if (txtemailvendedormodifica.Text != "")
                {
                    Boolean correo = verificar.email_bien_escrito(txtemailvendedormodifica.Text);
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
                    vendedor.modificar_vendedor(txtrutmodven.Text, txtnombrevendedormodifica.Text, txtapellidovendedormodifica.Text, int.Parse(txttelefonovendedormodifica.Text), txtdireccionvendedormodifica.Text, cbciudadvendedormodifica.Text, fechanacimientovendedormodifica.Value.ToShortDateString(), txtpreguntavendedormodifica.Text, txtrespuestavendedormodifica.Text, txtclavevendedormodifica.Text, int.Parse(txtsueldovendedormodifica.Text), txtemailvendedormodifica.Text, txtimagenvendedormodifica.Text);
                    MessageBox.Show("Modificación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cancelarmodificacion();
                }
                }
            
        
        private void cancelarmodificacion()
        {
            txtrutmodven.Enabled = true;
            txtnombrevendedormodifica.Enabled = false;
            txtapellidovendedormodifica.Enabled = false;
            txttelefonovendedormodifica.Enabled = false;
            txtdireccionvendedormodifica.Enabled = false;
            cbciudadvendedormodifica.Enabled = false;
            fechanacimientovendedormodifica.Enabled = false;
            txtpreguntavendedormodifica.Enabled = false;
            txtrespuestavendedormodifica.Enabled = false;
            txtclavevendedormodifica.Enabled = false;
            txtsueldovendedormodifica.Enabled = false;
            txtemailvendedormodifica.Enabled = false;
            txtimagenvendedormodifica.Enabled = false;
            btmodificarvendedor.Visible = false;
            btexaminarvendedormodifica.Visible = false;
            txtrutmodven.Clear();
            txtnombrevendedormodifica.Clear();
            txtapellidovendedormodifica.Clear();
            txttelefonovendedormodifica.Clear();
            txtdireccionvendedormodifica.Clear();
            cbciudadvendedormodifica.Text = "Seleccione";
            fechanacimientovendedormodifica.Value= DateTime.Now;
            txtpreguntavendedormodifica.Clear();
            txtrespuestavendedormodifica.Clear();
            txtclavevendedormodifica.Clear();
            txtsueldovendedormodifica.Clear();
            txtemailvendedormodifica.Clear();
            txtimagenvendedormodifica.Clear();
            btmodificarvendedor.Visible = false;
            btexaminarvendedormodifica.Visible = false;
            Btcancelarmodificarvendedor.Visible = false;
            fotovendedormodifica.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));
            

        }
        private void debloquearcamposbuscarmodifica()
        {
            txtrutmodven.Enabled = false;
            txtnombrevendedormodifica.Enabled = true;
            txtapellidovendedormodifica.Enabled = true;
            txttelefonovendedormodifica.Enabled = true;
            txtdireccionvendedormodifica.Enabled = true;
            cbciudadvendedormodifica.Enabled = true;
            fechanacimientovendedormodifica.Enabled = true;
            txtpreguntavendedormodifica.Enabled = true;
            txtrespuestavendedormodifica.Enabled = true;
            txtclavevendedormodifica.Enabled = true;
            txtsueldovendedormodifica.Enabled = true;
            txtemailvendedormodifica.Enabled = true;
            txtimagenvendedormodifica.Enabled = true;
            btmodificarvendedor.Visible = true;
            btexaminarvendedormodifica.Visible = true;
            Btcancelarmodificarvendedor.Visible = true;
        }

        private void Btcancelarmodificarvendedor_Click(object sender, EventArgs e)
        {
            cancelarmodificacion();
        }

        private void btexaminarvendedormodifica_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Pictures";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtimagenvendedormodifica.Text = abririmagen.FileName;
                fotovendedor.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotovendedormodifica.Image = (Image)imagen;

            }
        }

        private void txtrutmodven_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnombrevendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtapellidovendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdireccionvendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpreguntavendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrespuestavendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtemailvendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtimagenvendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtclavevendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:1234567890#.¿? " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefonovendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        private void txtsueldovendedormodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        

        private void txtdescripcionciudadvendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripcionciudadvendedor.Text == "")
            {
                label29.Visible = false;
            }
            else
            {
                label29.Visible = true;
                label29.Text = txtdescripcionciudadvendedor.TextLength.ToString();
            }
        }

        private void btagregarciudadvendedor_Click(object sender, EventArgs e)
        {
            if (txtnombreciudadvendedor.Text == "" || txtdescripcionciudadvendedor.Text == "")
            {
                MessageBox.Show("Debes Ingresar los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = ciudad.verificarciudad(txtnombreciudadvendedor.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Actualmente se encuentra registrada esa ciudad en el sistema");
                    txtnombreciudadvendedor.Clear();
                    txtdescripcionciudadvendedor.Clear();
                }
                else
                {
                    ciudad.insertarCiudad(txtnombreciudadvendedor.Text, txtdescripcionciudadvendedor.Text);
                    MessageBox.Show("Operación realizada con exito");
                    txtnombreciudadvendedor.Clear();
                    txtdescripcionciudadvendedor.Clear();
                }
            }
        }

        private void txtnombreciudadvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdescripcionciudadvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }
        private void btvolvermodificarvendedor_Click(object sender, EventArgs e)
        {
            DataSet ciudadvendedormodifica = ciudad.rescatardatosciudades();
            cbciudadvendedormodifica.Items.Clear();
            cbciudadvendedormodifica.Items.Add("Seleccione");
            for (int i = 0; i < ciudadvendedormodifica.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadagrevende.Items.Add(ciudadvendedormodifica.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudadvendedor.Visible = false;
            gbmodificavendedor.Visible = true;
            cbciudadvendedormodifica.Text = "Seleccione";

        }

        private void btagregarciudadmodifica_Click(object sender, EventArgs e)
        {
            gbmodificavendedor.Visible = false;
            gbagregaciudadvendedor.Visible = true;
            btvolvermodificarvendedor.Visible = true;
        }

        private void btvolveragregarvendedor_Click_1(object sender, EventArgs e)
        {
            DataSet ciudadvendedoragrega = ciudad.rescatardatosciudades();
            cbciudadagrevende.Items.Clear();
            cbciudadagrevende.Items.Add("Seleccione");
            for (int i = 0; i < ciudadvendedoragrega.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadagrevende.Items.Add(ciudadvendedoragrega.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudadvendedor.Visible = false;
            gbagregavendedor.Visible = true;
            cbciudadagrevende.Text = "Seleccione";
        }

        private void btagregaciudadvendedor_Click(object sender, EventArgs e)
        {
            gbagregavendedor.Visible = false;
            gbagregaciudadvendedor.Visible = true;
            btvolveragregarvendedor.Visible = true;
        }

        private void btvolvermenuprincipalvendedor_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();
        }

        
    }
}
