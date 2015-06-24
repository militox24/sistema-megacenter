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
    public partial class Mantenedor_Producto : Form
    {
        Gestion_Producto producto = new Gestion_Producto();
        Gestion_Categoria categoria = new Gestion_Categoria();
        Gestion_Proveedor proveedor = new Gestion_Proveedor();
        Gestion_Giro giro = new Gestion_Giro();
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
      
        string rutcompleto;
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado,correousuario;
        public Mantenedor_Producto(string nombre, string apellido, string rut,string url,string usuario,string correo)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
            correousuario = correo;
            cbproveedoragrega.Text = "Seleccione";
            cbcategoriaagrega.Text = "Seleccione";
            DataSet vercategoria = categoria.rescatardatoscategorias();
            for (int i = 0; i < vercategoria.Tables["Categoria"].Rows.Count; i++)
            {
                cbcategoriaagrega.Items.Add(vercategoria.Tables["Categoria"].Rows[i][0].ToString());
            }
            DataSet verproveedor = proveedor.rescatartodoslosproveedores();
            for (int i = 0; i < verproveedor.Tables["Proveedor"].Rows.Count; i++)
            {
                cbproveedoragrega.Items.Add(verproveedor.Tables["Proveedor"].Rows[i][1].ToString());
            }

        }
        public void omitir_caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void solo_numeros(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btcargaagregaproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = true;
            gbeliminaproducto.Visible = false;
            gbmodificarproducto.Visible = false;
            gbconsultarproducto.Visible = false;

            gbagregaproveedor.Visible = false;
            gbagregaciudad.Visible = false;
            gbagregagiro.Visible = false;
        }

        private void btcargaeliminarproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = false;
            gbeliminaproducto.Visible = true;
            gbmodificarproducto.Visible = false;
            gbconsultarproducto.Visible = false;
            gbagregaproveedor.Visible = false;
            gbagregaciudad.Visible = false;
            gbagregagiro.Visible = false;
            grillaeliminarproducto.DataSource = producto.rescata_productos();
            grillaeliminarproducto.DataMember = "Producto";
            grillaeliminarproducto.Columns["Cod_Producto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Proveedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Stock_Critico"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Precio_Venta"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Precio_Compra"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Url_Imagen"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarproducto.Columns["Nombre"].Width = 150;
            grillaeliminarproducto.Columns["Descripcion"].Width = 200;
            grillaeliminarproducto.Columns["Proveedor"].Width = 300;
            grillaeliminarproducto.Columns["Categoria"].Width = 100;
            grillaeliminarproducto.Columns["Url_Imagen"].Width = 100;
            inicializarCheckbox();


        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaeliminarproducto.RowCount; i++)
            {
                grillaeliminarproducto[1, i].ReadOnly = true;
                grillaeliminarproducto[2, i].ReadOnly = true;
                grillaeliminarproducto[3, i].ReadOnly = true;
                grillaeliminarproducto[4, i].ReadOnly = true;
                grillaeliminarproducto[5, i].ReadOnly = true;
                grillaeliminarproducto[6, i].ReadOnly = true;
                grillaeliminarproducto[7, i].ReadOnly = true;
                grillaeliminarproducto[8, i].ReadOnly = true;
                grillaeliminarproducto[9, i].ReadOnly = true;
                grillaeliminarproducto[0, i].Value = false;
                grillaeliminarproducto[0, i].ReadOnly = false;
            }
        }
        private void btcargamodificarproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = false;
            gbeliminaproducto.Visible = false;
            gbmodificarproducto.Visible = true;
            gbconsultarproducto.Visible = false;
            gbagregaproveedor.Visible = false;
            gbagregaciudad.Visible = false;
            gbagregagiro.Visible = false;
            DataSet vercategoria1 = categoria.rescatardatoscategorias();
            for (int i = 0; i < vercategoria1.Tables["Categoria"].Rows.Count; i++)
            {
                cbcategoriamod.Items.Add(vercategoria1.Tables["Categoria"].Rows[i][0].ToString());
            }
            DataSet verproveedor1 = proveedor.rescatartodoslosproveedores();
            for (int i = 0; i < verproveedor1.Tables["Proveedor"].Rows.Count; i++)
            {
                cbproveedormod.Items.Add(verproveedor1.Tables["Proveedor"].Rows[i][1].ToString());
            }
            cbproveedormod.Text = "Seleccione";
            cbcategoriamod.Text = "Seleccione";
        }

        private void btcargaconsultarproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = false;
            gbeliminaproducto.Visible = false;
            gbmodificarproducto.Visible = false;
            gbconsultarproducto.Visible = true;
            gbagregaproveedor.Visible = false;
            gbagregaciudad.Visible = false;
            gbagregagiro.Visible = false;
        }

        private void btexaminarproductoagregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:/Users/kmilo";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtimagenagrega.Text = abririmagen.FileName;
                fotoagregaproducto.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoagregaproducto.Image = (Image)imagen;

            }
        }

        private void btagregarproducto_Click(object sender, EventArgs e)
        {
            Boolean estado=false;
            string errores="Usted tiene los siguientes errores:\n";
            if(txtcodigobarraagrega.Text==""||txtnombreagrega.Text==""||txtdescripcionagrega.Text==""||cbcategoriaagrega.Text=="Seleccione"||cbproveedoragrega.Text=="Seleccione"||txtstockagrega.Text==""||txtstockcriticoagrega.Text==""||txtprecioventaagrega.Text==""||txtpreciocompraagrega.Text==""||txtimagenagrega.Text==""){
                errores = errores + "Faltan campos por completar\n";
                estado = true;
            }
            if(txtpreciocompraagrega.Text!="" || txtprecioventaagrega.Text!=""){

            if(int.Parse(txtpreciocompraagrega.Text)>int.Parse(txtprecioventaagrega.Text)){
                errores = errores + "El precio compra debe ser menor al precio de venta del producto\n";
                estado = true;
            }
            }
            if (estado == true)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = producto.verificarproducto(int.Parse(txtcodigobarraagrega.Text));
                if (ds.Tables["Producto"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un producto registrado en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    producto.insertar_Producto(int.Parse(txtcodigobarraagrega.Text),txtnombreagrega.Text,txtdescripcionagrega.Text,cbcategoriaagrega.Text,cbproveedoragrega.Text,int.Parse(txtstockagrega.Text),int.Parse(txtstockcriticoagrega.Text),int.Parse(txtprecioventaagrega.Text),int.Parse(txtpreciocompraagrega.Text),txtimagenagrega.Text);
                    MessageBox.Show("Operacion Realizada con exito","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtcodigobarraagrega.Clear();
                    txtnombreagrega.Clear();
                    txtdescripcionagrega.Clear();
                    cbcategoriaagrega.SelectedIndex = -1;
                    cbproveedoragrega.SelectedIndex = -1;
                    txtstockagrega.Clear();
                    txtstockcriticoagrega.Clear();
                    txtpreciocompraagrega.Clear();
                    txtprecioventaagrega.Clear();
                    txtimagenagrega.Clear();
                }
            }
        }

        private void btbuscareliminar_Click(object sender, EventArgs e)
        {
            if (txtbuscarcodigoeliminar.Text == "")
            {
                MessageBox.Show("Debes ingresar el codigo del producto a eliminar");
            }
            else
            {
                DataSet ds = producto.rescata_producto(int.Parse(txtbuscarcodigoeliminar.Text));
                if (ds.Tables["Producto"].Rows.Count > 0)
                {
                    grillaeliminarproducto.DataSource = producto.rescata_producto(int.Parse(txtbuscarcodigoeliminar.Text));
                    grillaeliminarproducto.DataMember = "Producto";
                    grillaeliminarproducto.Columns["Cod_Producto"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Proveedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Stock_Critico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Precio_Venta"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Precio_Compra"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Url_Imagen"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarproducto.Columns["Nombre"].Width = 150;
                    grillaeliminarproducto.Columns["Descripcion"].Width = 200;
                    grillaeliminarproducto.Columns["Proveedor"].Width = 300;
                    grillaeliminarproducto.Columns["Categoria"].Width = 100;
                    grillaeliminarproducto.Columns["Url_Imagen"].Width = 100;
                    inicializarCheckbox();

                }
                else
                {
                    MessageBox.Show("No existe un producto registrado con ese codigo en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btelimproducto_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            for (int i = 0; i < grillaeliminarproducto.RowCount; i++)
            {
                if (grillaeliminarproducto[0, i].Value.ToString() == "true")
                {
                    producto.Elimina_Producto(int.Parse(grillaeliminarproducto[1, i].Value.ToString()));
                    estado = true;
                }
                else
                {
                    MessageBox.Show("debes seleccionar el producto a eliminar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    estado = false;
                }
            }
            if (estado == true)
            {
                MessageBox.Show("Producto eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grillaeliminarproducto.DataSource = producto.rescata_productos();
                grillaeliminarproducto.DataMember = "Producto";
                grillaeliminarproducto.Columns["Cod_Producto"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Proveedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Stock_Critico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Precio_Venta"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Precio_Compra"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Url_Imagen"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaeliminarproducto.Columns["Nombre"].Width = 150;
                grillaeliminarproducto.Columns["Descripcion"].Width = 200;
                grillaeliminarproducto.Columns["Proveedor"].Width = 300;
                grillaeliminarproducto.Columns["Categoria"].Width = 100;
                grillaeliminarproducto.Columns["Url_Imagen"].Width = 100;
                inicializarCheckbox();
            }
        }

        private void btbuscarproducto_Click(object sender, EventArgs e)
        {
            if (txtbuscarproducto.Text == "")
            {
                MessageBox.Show("Debes ingresar el codigo del producto a eliminar");
            }
            else
            {
                DataSet ds = producto.rescata_producto(int.Parse(txtbuscarproducto.Text));
                if (ds.Tables["Producto"].Rows.Count > 0)
                {
                    grillaconsultarproducto.DataSource = producto.rescata_producto(int.Parse(txtbuscarproducto.Text));
                    grillaconsultarproducto.DataMember = "Producto";
                    grillaconsultarproducto.Columns["Cod_Producto"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Proveedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Stock_Critico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Precio_Venta"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Precio_Compra"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Url_Imagen"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultarproducto.Columns["Nombre"].Width = 150;
                    grillaconsultarproducto.Columns["Descripcion"].Width = 200;
                    grillaconsultarproducto.Columns["Proveedor"].Width = 300;
                    grillaconsultarproducto.Columns["Categoria"].Width = 100;
                    grillaconsultarproducto.Columns["Url_Imagen"].Width = 100;
                    txtbuscarproducto.Clear();
                    inicializarCheckbox();

                }
                else
                {
                    MessageBox.Show("No existe un producto registrado con ese codigo en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbuscarproducto.Clear();
                }

            }
        }

        private void btexaminarproductomod_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:/Users/kmilo";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txturlmod.Text = abririmagen.FileName;
                Fotoproductomod.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                Fotoproductomod.Image = (Image)imagen;

            }
        }

        private void btbuscarproductomod_Click(object sender, EventArgs e)
        {
            if (txtcodproductomod.Text == "")
            {
                MessageBox.Show("Debes ingresar el codigo del producto a Buscar");
            }
            else
            {
                DataSet ds = producto.rescata_producto(int.Parse(txtcodproductomod.Text));
                if (ds.Tables["Producto"].Rows.Count > 0)
                {
                    txtcodproductomod.Enabled = false;
                    txtnombremod.Enabled = true;
                    txtdescripcionmod.Enabled = true;
                    cbcategoriamod.Enabled = true;
                    cbproveedormod.Enabled = true;
                    txtstockmod.Enabled = true;
                    txtstockcriticomod.Enabled = true;
                    txtprecioventamod.Enabled = true;
                    txtpreciocompramod.Enabled = true;
                    txturlmod.Enabled = true;
                    btexaminarproductomod.Visible = true;
                    btmodificarproducto.Visible = true;
                    txtnombremod.Text=ds.Tables["Producto"].Rows[0][1].ToString();
                    txtdescripcionmod.Text = ds.Tables["Producto"].Rows[0][2].ToString();
                    cbcategoriamod.Text = ds.Tables["Producto"].Rows[0][3].ToString();
                    cbproveedormod.Text = ds.Tables["Producto"].Rows[0][4].ToString();
                    txtstockmod.Text = ds.Tables["Producto"].Rows[0][5].ToString();
                    txtstockcriticomod.Text = ds.Tables["Producto"].Rows[0][6].ToString();
                    txtprecioventamod.Text = ds.Tables["Producto"].Rows[0][7].ToString();
                    txtpreciocompramod.Text = ds.Tables["Producto"].Rows[0][8].ToString();
                    txturlmod.Text = ds.Tables["Producto"].Rows[0][9].ToString();
                    Fotoproductomod.Image = Image.FromFile(Path.Combine(Application.StartupPath, "" + txturlmod.Text + ""));
                    Fotoproductomod.SizeMode = PictureBoxSizeMode.StretchImage;
                   
                }
                else
                {
                    MessageBox.Show("No existe un producto registrado con ese codigo en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
        }

        private void btmodificarproducto_Click(object sender, EventArgs e)
        {
            if (txtnombremod.Text == "" || txtdescripcionmod.Text == "" || cbcategoriamod.Text == "Seleccione" || cbcategoriamod.Text == "Seleccione" || txtstockmod.Text == "" || txtstockcriticomod.Text == "" || txtpreciocompramod.Text == "" || txtprecioventamod.Text == "" || txturlmod.Text == "")
            {
                MessageBox.Show("Debes ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                producto.modificadatosproducto(int.Parse(txtcodproductomod.Text),txtnombremod.Text,txtdescripcionmod.Text,cbcategoriamod.Text,cbproveedormod.Text,int.Parse(txtstockmod.Text),int.Parse(txtstockcriticomod.Text),int.Parse(txtprecioventamod.Text),int.Parse(txtpreciocompramod.Text),txturlmod.Text);
                MessageBox.Show("Modificacion Realizada con exito","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtcodproductomod.Enabled = true;
                txtnombremod.Enabled = false;
                txtdescripcionmod.Enabled = false;
                cbcategoriamod.Enabled = false;
                cbproveedormod.Enabled = false;
                txtstockmod.Enabled = false;
                txtstockcriticomod.Enabled = false;
                txtprecioventamod.Enabled = false;
                txtpreciocompramod.Enabled = false;
                txturlmod.Enabled = false;
                btexaminarproductomod.Visible = false;
                btmodificarproducto.Visible = false;
                txtcodproductomod.Clear();
                txtnombremod.Clear();
                txtdescripcionmod.Clear();
                cbcategoriamod.SelectedIndex = -1;
                cbproveedormod.SelectedIndex = -1;
                txtstockmod.Clear();
                txtstockcriticomod.Clear();
                txtprecioventamod.Clear();
                txtpreciocompramod.Clear();
                txturlmod.Clear();
            }
        }

        private void btvolvermenuprincipalproducto_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado,correousuario);
            this.Hide();
            principal.Show();

        }

        private void txtbuscarcodigoeliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void btagregarproveedorproducto_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            VerificarRut rut = new VerificarRut();
            string errores = "Usted tiene los siguientes errores:\n";
            if (txtrutproveedoragregapro.Text == "" || txtdigitoproveedoragregapro.Text == "" || txtnombreproveedoragregapro.Text == "" || txtdescripcionproveedoragregapro.Text == "" || txtdireccionagregapro.Text == "" || txtemailproveedorsagregapro.Text == "" || txturlproveedoragregapro.Text == "" || cbciudadproveedoragregapro.Text == "Seleccione" || cbgiroproveedoragregapro.Text == "Seleccione")
            {
                errores = errores + "Debes completar todos los campos\n";
                estado = true;
            }
            if (txtdescripcionproveedoragregapro.TextLength > 150)
            {
                errores = errores + "La descripcion debe tener menos de 150 caracteres\n";
                estado = true;
            }
            if (txtrutproveedoragregapro.Text != "" && txtdigitoproveedoragregapro.Text != "")
            {

                string digito = rut.digitoVerificador(int.Parse(txtrutproveedoragregapro.Text));
                if (txtdigitoproveedoragregapro.Text != digito)
                {
                    errores = errores + "El rut ingresado no es valido\n";
                    estado = true;
                }
                else
                {
                    rutcompleto = txtrutproveedoragregapro.Text + "-" + txtdigitoproveedoragregapro.Text;
                }
            }

            if (txtemailproveedorsagregapro.Text != "")
            {
                Boolean correo = rut.email_bien_escrito(txtemailproveedorsagregapro.Text);
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
                DataSet verificaproveedor = proveedor.verificarexistenciaproveedor(rutcompleto);
                if (verificaproveedor.Tables["Proveedor"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un Proveedor registrado en el sistema ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    proveedor.ingresarproveedor(rutcompleto, txtnombreproveedoragregapro.Text, txtdescripcionproveedoragregapro.Text, txtdireccionagregapro.Text, cbciudadproveedoragregapro.Text, cbgiroproveedoragregapro.Text, int.Parse(txttelefonoproveedoragregapro.Text), txtemailproveedorsagregapro.Text, txturlproveedoragregapro.Text);
                    MessageBox.Show("Operación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtrutproveedoragregapro.Clear();
                    txtdigitoproveedoragregapro.Clear();
                    txtnombreproveedoragregapro.Clear();
                    txtdescripcionproveedoragregapro.Clear();
                    txtdireccionagregapro.Clear();
                    cbciudadproveedoragregapro.SelectedIndex = -1;
                    cbgiroproveedoragregapro.SelectedIndex = -1;
                    txttelefonoproveedoragregapro.Clear();
                    txtemailproveedorsagregapro.Clear();
                    txturlproveedoragregapro.Clear();
                    fotoproveedoragregapro.Image = Image.FromFile(Path.Combine(Application.StartupPath, "C:\\Users\\kmilo\\Documents\\Visual Studio 2010\\Projects\\sistema megacenter\\sistema megacenter\\imagenes\\user.png"));
                }
            }
        }

        private void btexaminaragregarproveedorpro_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:/Users/kmilo";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txturlproveedoragregapro.Text = abririmagen.FileName;
                Fotoproductomod.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(directory);

                fotoproveedoragregapro.Image = (Image)imagen;

            }
        }

        private void txtdigitoproveedoragregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrutproveedoragregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void txttelefonoproveedoragregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender, e);
        }

        private void btagregarciudadpro_Click(object sender, EventArgs e)
        {
            if (txtnombreciudadpro.Text == "" || txtdescripcionciudadpro.Text == "")
            {
                MessageBox.Show("Debes Ingresar los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = ciudad.verificarciudad(txtnombreciudadpro.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Actualmente se encuentra registrada esa ciudad en el sistema");
                    txtnombreciudadpro.Clear();
                    txtdescripcionciudadpro.Clear();
                }
                else
                {
                    ciudad.insertarCiudad(txtnombreciudadpro.Text, txtdescripcionciudadpro.Text);
                    MessageBox.Show("Operación realizada con exito");
                    txtnombreciudadpro.Clear();
                    txtdescripcionciudadpro.Clear();
                }
            }
        }

        private void txtnombreciudadpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdescripcionciudadpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void btvolvermenuprincipalpro1_Click(object sender, EventArgs e)
        {
             DataSet ciudadproveedormodifica = ciudad.rescatardatosciudades();
            cbciudadproveedoragregapro.Items.Clear();
            cbciudadproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < ciudadproveedormodifica.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedoragregapro.Items.Add(ciudadproveedormodifica.Tables["Ciudad"].Rows[i][0].ToString());
            }
            gbagregaciudad.Visible = false;
            gbagregaproveedor.Visible = true;
            cbciudadproveedoragregapro.Text = "Seleccione";
        }

        private void btagregargiro_Click(object sender, EventArgs e)
        {
            string errores = "Usted tiene los siguientes errores:\n";
            Boolean estado = false;
            if (txtgiroagregapro.Text == "" || txtdescripciongiropro.Text == "")
            {
                errores = errores + "Debes completar todos los campos\n";
                estado = true;
            }
            if (txtgiroagregapro.TextLength > 40)
            {
                errores = errores + "el giro debe contener menos de 40 carateres\n";
                estado = true;
            }
            if (txtdescripciongiropro.TextLength > 150)
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
                DataSet verificaexistencia =giro.verificar_giro(txtgiroagregapro.Text);
                if (verificaexistencia.Tables["Giro"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un registro asociado con ese nombre de giro en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgiroagregapro.Clear();
                    txtdescripciongiropro.Clear();
                }
                else
                {
                    giro.registrar_giro(txtgiroagregapro.Text, txtdescripciongiropro.Text);
                    MessageBox.Show("Operación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgiroagregapro.Clear();
                    txtdescripciongiropro.Clear();



                }
            }
        }

        private void txtdescripciongiropro_TextChanged(object sender, EventArgs e)
        {
            label35.Text = txtdescripciongiropro.TextLength.ToString();
        }

        private void btvolverproveedor2_Click(object sender, EventArgs e)
        {
            DataSet giroproveedormodifica = giro.rescatar_giros();
            cbgiroproveedoragregapro.Items.Clear();
            cbgiroproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < giroproveedormodifica.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedoragregapro.Items.Add(giroproveedormodifica.Tables["Giro"].Rows[i][0].ToString());
            }
            gbagregagiro.Visible = false;
            gbagregaproveedor.Visible = true;
            cbgiroproveedoragregapro.Text = "Seleccione";
        }

        private void txtgiroagregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdescripciongiropro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void btagregacategoriaagre_Click(object sender, EventArgs e)
        {
            if (txtcateagreproducto.Text == "" || txtdescripacateproducto.Text == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificaexistenciacategoria = categoria.verificarcategoria(txtcateagreproducto.Text);
                if (verificaexistenciacategoria.Tables["Categoria"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe una categoria registrada con ese nombre en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcateagreproducto.Clear();
                    txtdescripacateproducto.Clear();
                }
                else
                {
                    categoria.insertarCategoria(txtcateagreproducto.Text, txtdescripacateproducto.Text);
                    MessageBox.Show("Categoria Agregada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcateagreproducto.Clear();
                    txtdescripacateproducto.Clear();
                }
            }
        }

        private void txtcateagreproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);

        }

        private void txtdescripacateproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void btvolvermenucategoria1_Click(object sender, EventArgs e)
        {
            DataSet categorias= categoria.rescatardatoscategorias();
            cbcategoriaagrega.Items.Clear();
            cbcategoriaagrega.Items.Add("Seleccione");
            for (int i = 0; i < categorias.Tables["Categoria"].Rows.Count; i++)
            {
                cbcategoriaagrega.Items.Add(categorias.Tables["Categoria"].Rows[i][0].ToString());
            }
            gbagrecategoria.Visible = false;
            gbagregaproducto.Visible = true;
            cbcategoriaagrega.Text = "Seleccione";
        }

        private void btvolvermenucategoria2_Click(object sender, EventArgs e)
        {
            DataSet categorias = categoria.rescatardatoscategorias();
            cbcategoriamod.Items.Clear();
            cbcategoriamod.Items.Add("Seleccione");
            for (int i = 0; i < categorias.Tables["Categoria"].Rows.Count; i++)
            {
                cbcategoriamod.Items.Add(categorias.Tables["Categoria"].Rows[i][0].ToString());
            }
            gbagrecategoria.Visible = false;
            gbmodificarproducto.Visible = true;
            cbcategoriamod.Text = "Seleccione";
        }

        private void btagregaciudad_Click(object sender, EventArgs e)
        {
            btvolvermenuprincipalpro1.Visible = true;
            gbagregaciudad.Visible = true;
            gbagregaproveedor.Visible = false;
        }

        private void btcategoriaagrega_Click(object sender, EventArgs e)
        {
            btvolvermenucategoria1.Visible = true;
            gbagregaproducto.Visible = false;
            gbagrecategoria.Visible = true;
        }

        private void btagregacategoriamod_Click(object sender, EventArgs e)
        {
            btvolvermenucategoria2.Visible = true;
            gbagrecategoria.Visible = true;
            gbmodificarproducto.Visible = false;
        }

        private void btagregagiro_Click(object sender, EventArgs e)
        {
            gbagregagiro.Visible = true;
            gbagregaproveedor.Visible = false;
        }

        private void gbagregagiro_Enter(object sender, EventArgs e)
        {

        }

        private void btvolver3_Click(object sender, EventArgs e)
        {
            DataSet proveedor1 = proveedor.rescatartodoslosproveedores();
            cbproveedoragrega.Items.Clear();
            cbproveedoragrega.Items.Add("Seleccione");
            for (int i = 0; i < proveedor1.Tables["Proveedor"].Rows.Count; i++)
            {
                cbproveedoragrega.Items.Add(proveedor1.Tables["Proveedor"].Rows[i][0].ToString());
            }
            gbagregaproveedor.Visible = false;
            gbagregaproducto.Visible = true;
            cbproveedoragrega.Text = "Seleccione";
        }

        private void btvolver4_Click(object sender, EventArgs e)
        {
            DataSet proveedor2 = proveedor.rescatartodoslosproveedores();
            cbproveedormod.Items.Clear();
            cbproveedormod.Items.Add("Seleccione");
            for (int i = 0; i < proveedor2.Tables["Proveedor"].Rows.Count; i++)
            {
                cbproveedoragrega.Items.Add(proveedor2.Tables["Proveedor"].Rows[i][0].ToString());
            }
            gbagregaproveedor.Visible = false;
            gbmodificarproducto.Visible = true;
            cbproveedormod.Text = "Seleccione";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btvolver3.Visible = true;
            gbagregaproducto.Visible = false;
            gbagregaproveedor.Visible = true;
            DataSet ciudades = ciudad.rescatardatosciudad();
            cbciudadproveedoragregapro.Items.Clear();
            cbciudadproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < ciudades.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedoragregapro.Items.Add(ciudades.Tables["Ciudad"].Rows[i][0].ToString());
            }
            cbciudadproveedoragregapro.Text = "Seleccione";

            DataSet giros = giro.rescatar_giros();
            cbgiroproveedoragregapro.Items.Clear();
            cbgiroproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < giros.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedoragregapro.Items.Add(giros.Tables["Giro"].Rows[i][0].ToString());
            }
            cbgiroproveedoragregapro.Text = "Seleccione";
        }

        private void btproveedoragregaproducto_Click(object sender, EventArgs e)
        {
            btvolver4.Visible = true;
            gbagregaproveedor.Visible = true;
            gbmodificarproducto.Visible = false;
            DataSet ciudades1 = ciudad.rescatardatosciudad();
            cbciudadproveedoragregapro.Items.Clear();
            cbciudadproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < ciudades1.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadproveedoragregapro.Items.Add(ciudades1.Tables["Ciudad"].Rows[i][0].ToString());
            }
            cbciudadproveedoragregapro.Text = "Seleccione";

            DataSet giros1 = giro.rescatar_giros();
            cbgiroproveedoragregapro.Items.Clear();
            cbgiroproveedoragregapro.Items.Add("Seleccione");
            for (int i = 0; i < giros1.Tables["Giro"].Rows.Count; i++)
            {
                cbgiroproveedoragregapro.Items.Add(giros1.Tables["Giro"].Rows[i][0].ToString());
            }
            cbgiroproveedoragregapro.Text = "Seleccione";
           
        }

        private void txtcodproductomod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void txtnombremod_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdescripcionmod_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtstockmod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void txtstockcriticomod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender, e);
        }

        private void txtprecioventamod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender, e);
        }

        private void txtpreciocompramod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender, e);
        }

        private void txtnombreproveedoragregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdescripcionproveedoragregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdireccionagregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtemailproveedorsagregapro_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú:@/" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcodigobarraagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void txtnombreagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtdescripcionagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            omitir_caracteres(sender,e);
        }

        private void txtstockagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

        private void txtstockcriticoagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
             solo_numeros(sender,e);
        }

        private void txtprecioventaagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
             solo_numeros(sender,e);
        }

        private void txtpreciocompraagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
             solo_numeros(sender,e);
        }

        private void txtbuscarproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(sender,e);
        }

    }
}
