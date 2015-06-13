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
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado;
        public Mantenedor_Producto(string nombre, string apellido, string rut,string url,string usuario)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
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

        private void btcargaagregaproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = true;
            gbeliminaproducto.Visible = false;
            gbmodificarproducto.Visible = false;
            gbconsultarproducto.Visible = false;
        }

        private void btcargaeliminarproducto_Click(object sender, EventArgs e)
        {
            gbagregaproducto.Visible = false;
            gbeliminaproducto.Visible = true;
            gbmodificarproducto.Visible = false;
            gbconsultarproducto.Visible = false;
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
            for (int i = 0; i < grillaeliminarproducto.RowCount; i++)
            {
                if (grillaeliminarproducto[0, i].Value.ToString() == "true")
                {
                    producto.Elimina_Producto(int.Parse(grillaeliminarproducto[1, i].Value.ToString()));
                }
            }
            MessageBox.Show("Producto eliminado correctamente","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();

        }

       

       

      


    }
}
