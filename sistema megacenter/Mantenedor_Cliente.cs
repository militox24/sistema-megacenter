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
    public partial class Mantenedor_Cliente : Form
    {
        string rutcompleto;
        Gestión_Ciudad ciudad = new Gestión_Ciudad();
        Gestion_Cliente cliente = new Gestion_Cliente();
        VerificarRut verifica = new VerificarRut();
        string nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado,correologueado;
        public Mantenedor_Cliente(string nombre,string apellido,string rut,string url,string usuario,string correo)
        {
            InitializeComponent();
            DataSet ds = ciudad.rescatardatosciudad();
            for (int i = 0; i < ds.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciudadcliente.Items.Add(ds.Tables["Ciudad"].Rows[i][0].ToString());
            }
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
            correologueado = correo;
        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaelimcliente.RowCount; i++)
            {
                grillaelimcliente[1, i].ReadOnly = true;
                grillaelimcliente[2, i].ReadOnly = true;
                grillaelimcliente[0, i].Value = false;
                grillaelimcliente[0, i].ReadOnly = false;
            }
        }

        private void btcargaagregacliente_Click(object sender, EventArgs e)
        {
            gbagrecliente.Visible = true;
            gbeliminacliente.Visible = false;
            gbmodificacliente.Visible = false;
        }

        private void btcargaelimcliente_Click(object sender, EventArgs e)
        {
            gbagrecliente.Visible = false;
            gbeliminacliente.Visible = true;
            gbmodificacliente.Visible = false;
            grillaelimcliente.DataSource = cliente.rescatardatoscliente();
            grillaelimcliente.DataMember = "Cliente";
            grillaelimcliente.Columns["Rut_Cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcliente.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcliente.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcliente.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcliente.Columns["Correo_Electronico"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcliente.Columns["Nombres"].Width = 150;
            grillaelimcliente.Columns["Apellidos"].Width = 200;
            grillaelimcliente.Columns["Correo_Electronico"].Width = 200;
            inicializarCheckbox();
        }

        private void btcargamodicliente_Click(object sender, EventArgs e)
        {
            gbagrecliente.Visible = false;
            gbeliminacliente.Visible = false;
            gbmodificacliente.Visible = true;
            DataSet ds6 = ciudad.rescatardatosciudad();
            for (int i = 0; i < ds6.Tables["Ciudad"].Rows.Count; i++)
            {
                cbciuclimod.Items.Add(ds6.Tables["Ciudad"].Rows[i][0].ToString());
            }
        }
        private void reiniciamantenedor()
        {
            txtapellidocliente.Clear();
            txtcorreocliente.Clear();
            txtdigitocliente.Clear();
            txtdireccioncliente.Clear();
            txtnombrecliente.Clear();
            txtrutcliente.Clear();
            txttelefonocliente.Clear();
            cbciudadcliente.SelectedIndex = -1;
            cbsexoclienteagre.SelectedIndex = -1;
        }

        private void btagregacliente_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errores = "";

            if (txtrutcliente.Text == "" || txtdigitocliente.Text == "" || txtnombrecliente.Text == "" || txtapellidocliente.Text == "" || txtdireccioncliente.Text == "" || cbciudadcliente.Text == "Seleccione" || txttelefonocliente.Text == "" || cbsexoclienteagre.Text == "Seleccione" || txtcorreocliente.Text == "")
            {
                errores = errores + "debes ingresar todos los datos solicitados\n";
                error = true;
            }
            int rut;
            int.TryParse(txtrutcliente.Text, out rut);
            VerificarRut verifica = new VerificarRut();
            string digito = verifica.digitoVerificador(rut);
            if (txtdigitocliente.Text != digito)
            {
                errores = errores + "el rut ingresado no es valido\n";
                error = true;
            }
            else
            {
                rutcompleto = txtrutcliente.Text + "-" + txtdigitocliente.Text;
            }
            if (txtcorreocliente.Text != "")
            {
                Boolean estado = verifica.email_bien_escrito(txtcorreocliente.Text);
                if (estado == false)
                {
                    errores = errores + "Debes ingresar una direccion de correo valida\n";
                    error = true;
                }
            }

            if (error == true)
            {
                MessageBox.Show(errores,"Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds2 = cliente.verificarexistencia(rutcompleto);
                if (ds2.Tables["Cliente"].Rows.Count > 0)
                {
                    MessageBox.Show("ya existe un usuario registrado en el sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    reiniciamantenedor();
                }
                else
                {
                    int telefono = int.Parse(txttelefonocliente.Text);
                    cliente.insertarCliente(rutcompleto, txtnombrecliente.Text, txtapellidocliente.Text, dateTimePicker1.Value.ToString(), txtdireccioncliente.Text, cbciudadcliente.Text, telefono, cbsexoclienteagre.Text, txtcorreocliente.Text);
                    MessageBox.Show("Cliente agregado exitosamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    reiniciamantenedor();
                }
            }
        }

        private void btbuscarclienteeliminar_Click(object sender, EventArgs e)
        {
            if (txtrutelimcliente.Text == "")
            {
                MessageBox.Show("debes ingresar el rut del cliente a eliminar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtrutelimcliente.Clear();
            }
            else
            {
                DataSet ds = cliente.verificarexistencia(txtrutelimcliente.Text);
                if (ds.Tables["Cliente"].Rows.Count > 0)
                {
                    grillaelimcliente.DataSource = cliente.rescatardatosclientes(txtrutelimcliente.Text);
                    grillaelimcliente.DataMember = "Cliente";
                    grillaelimcliente.Columns["Rut_Cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcliente.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcliente.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcliente.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcliente.Columns["Correo_Electronico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcliente.Columns["Nombres"].Width = 150;
                    grillaelimcliente.Columns["Apellidos"].Width = 200;
                    grillaelimcliente.Columns["Correo_Electronico"].Width = 200;
                    inicializarCheckbox();
                    txtrutelimcliente.Clear();
                }
                else
                {
                    MessageBox.Show("No existe un un cliente registrado con ese rut","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtrutelimcliente.Clear();
                }
            }
        }

        private void btelimcliente_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            for (int i = 0; i < grillaelimcliente.RowCount; i++)
            {
                if (grillaelimcliente[0, i].Value.ToString() == "true")
                {
                    cliente.Elimina_cliente(grillaelimcliente[1, i].Value.ToString());
                    estado = true;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la cliente a eliminar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    estado = false;
                }
            }
            if(estado==true){
                MessageBox.Show("Cliente Eliminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grillaelimcliente.DataSource = cliente.rescatardatoscliente();
                grillaelimcliente.DataMember = "Cliente";
                grillaelimcliente.Columns["Rut_Cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcliente.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcliente.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcliente.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcliente.Columns["Correo_Electronico"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcliente.Columns["Nombres"].Width = 150;
                grillaelimcliente.Columns["Apellidos"].Width = 200;
                grillaelimcliente.Columns["Correo_Electronico"].Width = 200;
                inicializarCheckbox();
            }
          
        }

        private void btbuscaclientemodifica_Click(object sender, EventArgs e)
        {
            DataSet ds7 = cliente.rescatadatosmod(txtrutmodicliente.Text);
            if (ds7.Tables["Cliente"].Rows.Count == 0)
            {
                MessageBox.Show("No existe un cliente registrado con ese rut en el sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                reiniciarmantenedormodificar();
            }
            else
            {
                txtrutmodicliente.Enabled = false;
                txtnomcliemod.Enabled = true;
                txtapecliemod.Enabled = true;
                dateTimePicker2.Enabled = true;
                txtdirecliemod.Enabled = true;
                cbciuclimod.Enabled = true;
                txttelclimod.Enabled = true;
                cbsexclienmod.Enabled = true;
                txtcorrcliemod.Enabled = true;
                btmodificarcliente.Visible = true;
                txtnomcliemod.Text = ds7.Tables["Cliente"].Rows[0][1].ToString();
                txtapecliemod.Text = ds7.Tables["Cliente"].Rows[0][2].ToString();
                dateTimePicker2.Value = DateTime.Parse(ds7.Tables["Cliente"].Rows[0][3].ToString());
                txtdirecliemod.Text = ds7.Tables["Cliente"].Rows[0][4].ToString();
                cbciuclimod.Text = ds7.Tables["Cliente"].Rows[0][5].ToString();
                txttelclimod.Text = ds7.Tables["Cliente"].Rows[0][6].ToString();
                cbsexclienmod.Text = ds7.Tables["Cliente"].Rows[0][7].ToString();
                txtcorrcliemod.Text = ds7.Tables["Cliente"].Rows[0][8].ToString();
            }
        }
        private void reiniciarmantenedormodificar()
        {
            txtrutmodicliente.Clear();
            txtnomcliemod.Clear();
            txtapecliemod.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtdirecliemod.Clear();
            cbciuclimod.SelectedIndex = -1;
            txttelclimod.Clear();
            cbsexclienmod.SelectedIndex = -1;
            txtcorrcliemod.Clear();
        }

        private void btmodificarcliente_Click(object sender, EventArgs e)
        {
            if (txtrutmodicliente.Text == "" || txtnomcliemod.Text == "" || txtapecliemod.Text == "" || txtdirecliemod.Text == "" || cbciuclimod.Text == "Seleccione" || txttelclimod.Text == "" || cbsexclienmod.Text == "Seleccione" || txtcorrcliemod.Text == "")
            {
                MessageBox.Show("Debes ingresar los datos solicitados","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int telefono = int.Parse(txttelclimod.Text);
                cliente.modificadatoscliente(txtrutmodicliente.Text, txtnomcliemod.Text, txtapecliemod.Text, dateTimePicker2.Value.ToString(), txtdirecliemod.Text, cbciuclimod.Text, telefono, cbsexclienmod.Text, txtcorrcliemod.Text);
                MessageBox.Show("Operación realizada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtrutmodicliente.Enabled = true;
                txtnomcliemod.Enabled = false;
                txtapecliemod.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtdirecliemod.Enabled = false;
                cbciuclimod.Enabled = false;
                txttelclimod.Enabled = false;
                cbsexclienmod.Enabled = false;
                txtcorrcliemod.Enabled = false;
                btmodificarcliente.Visible = false;
                reiniciarmantenedormodificar();


            }
        }

        private void btvolvermenuprincipal3_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado,correologueado);
            this.Hide();
            principal.Show();

        }

        private void txtrutcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtdigitocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú\\@/:. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
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

        private void txtnombrecliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtapellidocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdireccioncliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtcorreocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtnomcliemod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtapecliemod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtdirecliemod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtcorrcliemod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender, e);
        }

        private void txtrutmodicliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtrutelimcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txttelefonocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender,e);
        }

        private void txttelclimod_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(sender, e);
        }

        private void btcancelarmodificacliente_Click(object sender, EventArgs e)
        {
            txtrutmodicliente.Enabled = true;
            txtnomcliemod.Enabled = false;
            txtapecliemod.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtdirecliemod.Enabled = false;
            cbciuclimod.Enabled = false;
            txttelclimod.Enabled = false;
            cbsexclienmod.Enabled = false;
            txtcorrcliemod.Enabled = false;
            btmodificarcliente.Visible = false;
            reiniciarmantenedormodificar();
        }

        private void btcancelaragregacliente_Click(object sender, EventArgs e)
        {
            reiniciamantenedor();
        }
    }
}
