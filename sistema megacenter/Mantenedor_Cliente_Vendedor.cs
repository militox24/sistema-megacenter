using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistema_megacenter
{
    public partial class Mantenedor_Cliente_Vendedor : Form
    {
        string nombreusuario, apellidousuario, url_foto, rutusuario, usuariologueado;
        string rutcompleto;
        Gestion_Cliente cliente = new Gestion_Cliente();
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        public Mantenedor_Cliente_Vendedor(string nombre,string apellido,string url,string rut,string usuario)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            url_foto = url;
            rutusuario = rut;
            usuariologueado = usuario;
            DataSet ds = ciudad.rescatardatosciudad();
            for (int i = 0; i < ds.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadclientevendedor.Items.Add(ds.Tables["Ciudad"].Rows[i][0].ToString());
            }
        }

        private void btcargaagregaclientevendedor_Click(object sender, EventArgs e)
        {
            gbagreclientevendedor.Visible = true;
            gbconsultaclientevendedor.Visible = false;
        }

        private void btcargaconsultaclientevendedor_Click(object sender, EventArgs e)
        {
            gbconsultaclientevendedor.Visible = true;
            gbagreclientevendedor.Visible = false;
        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaconsultacliente.RowCount; i++)
            {
                grillaconsultacliente[1, i].ReadOnly = true;
                grillaconsultacliente[2, i].ReadOnly = true;
                grillaconsultacliente[0, i].ReadOnly = false;
            }
        }
        private void btbuscarclienteeliminar_Click(object sender, EventArgs e)
        {
            if (txtrutconsultacliente.Text == "")
            {
                MessageBox.Show("debes ingresar el rut del cliente a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrutconsultacliente.Clear();
            }
            else
            {
                grillaconsultacliente.DataSource = cliente.rescatardatosclientes(txtrutconsultacliente.Text);
                grillaconsultacliente.DataMember = "Cliente";
                grillaconsultacliente.Columns["Rut_Cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultacliente.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultacliente.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultacliente.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultacliente.Columns["Correo_Electronico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultacliente.Columns["Nombres"].Width = 150;
                grillaconsultacliente.Columns["Apellidos"].Width = 200;
                grillaconsultacliente.Columns["Correo_Electronico"].Width = 200;
                inicializarCheckbox();
                txtrutconsultacliente.Clear();
            }
        }

        private void btagregaclientevendedor_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errores = "";

            if (txtrutclientevendedor.Text == "" || txtdigitoclientevendedor.Text == "" || txtnombreclientevendedor.Text == "" || txtapellidoclientevendedor.Text == "" || txtdireccionclientevendedor.Text == "" || cbciudadclientevendedor.Text == "Seleccione" || txttelefonoclientevendedor.Text == "" || cbsexoclienteagrevendedor.Text == "Seleccione" || txtcorreoclientevendedor.Text == "")
            {
                errores = errores + "debes ingresar todos los datos solicitados\n";
                error = true;
            }
            int rut;
            int.TryParse(txtrutclientevendedor.Text, out rut);
            VerificarRut verifica = new VerificarRut();
            string digito = verifica.digitoVerificador(rut);
            if (txtdigitoclientevendedor.Text != digito)
            {
                errores = errores + "el rut ingresado no es valido\n";
                error = true;
            }
            else
            {
                rutcompleto = txtrutclientevendedor.Text + "-" + txtdigitoclientevendedor.Text;
            }
            if (txtcorreoclientevendedor.Text != "")
            {
                Boolean estado = verifica.email_bien_escrito(txtcorreoclientevendedor.Text);
                if (estado == false)
                {
                    errores = errores + "Debes ingresar una direccion de correo valida\n";
                    error = true;
                }
            }

            if (error == true)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds2 = cliente.verificarexistencia(rutcompleto);
                if (ds2.Tables["Cliente"].Rows.Count > 0)
                {
                    MessageBox.Show("ya existe un usuario registrado en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reiniciamantenedor();
                }
                else
                {
                    int telefono = int.Parse(txttelefonoclientevendedor.Text);
                    cliente.insertarCliente(rutcompleto, txtnombreclientevendedor.Text, txtapellidoclientevendedor.Text, dateTimePicker1.Value.ToString(), txtdireccionclientevendedor.Text, cbciudadclientevendedor.Text, telefono, cbsexoclienteagrevendedor.Text, txtcorreoclientevendedor.Text);
                    MessageBox.Show("Cliente agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reiniciamantenedor();
                }
            }
        }
        private void reiniciamantenedor()
        {
            txtapellidoclientevendedor.Clear();
            txtcorreoclientevendedor.Clear();
            txtdigitoclientevendedor.Clear();
            txtdireccionclientevendedor.Clear();
            txtnombreclientevendedor.Clear();
            txtrutclientevendedor.Clear();
            txttelefonoclientevendedor.Clear();
            cbciudadclientevendedor.SelectedIndex = -1;
            cbsexoclienteagrevendedor.SelectedIndex = -1;
        }

        private void btvolvermenuprincipalvendedor1_Click(object sender, EventArgs e)
        {
            Menu_Vendedor principal = new Menu_Vendedor(nombreusuario,apellidousuario,url_foto,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();

        }
    }
}
