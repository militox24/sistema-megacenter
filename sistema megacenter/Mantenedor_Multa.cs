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
    public partial class Mantenedor_Multa : Form
    {
        Gestion_Multa multa = new Gestion_Multa();
        string nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado;
        public Mantenedor_Multa(string nombre, string apellido, string rut, string url,string usuario)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
        }
        private void Btcargaagregamulta_Click(object sender, EventArgs e)
        {
            gbagregarmulta.Visible = true;
            gbeliminarmulta.Visible = false;
            gbconsultarMulta.Visible = false;

        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaeliminarmulta.RowCount; i++)
            {
                grillaeliminarmulta[1, i].ReadOnly = true;
                grillaeliminarmulta[2, i].ReadOnly = true;
                grillaeliminarmulta[3, i].ReadOnly = true;
                grillaeliminarmulta[4, i].ReadOnly = true;
                grillaeliminarmulta[5, i].ReadOnly = true;
                grillaeliminarmulta[0, i].Value = false;
                grillaeliminarmulta[0, i].ReadOnly = false;
            }
            for (int i = 0; i < grilllaconsultarmulta.RowCount; i++)
            {
                grilllaconsultarmulta[0, i].ReadOnly = true;
                grilllaconsultarmulta[1, i].ReadOnly = true;
                grilllaconsultarmulta[2, i].ReadOnly = true;
                grilllaconsultarmulta[3, i].ReadOnly = true;
                grilllaconsultarmulta[4, i].ReadOnly = true;
               
            }
        }
        private void Btcargaeliminamulta_Click(object sender, EventArgs e)
        {
            gbagregarmulta.Visible = false;
            gbeliminarmulta.Visible = true;
            gbconsultarMulta.Visible = false;
            grillaeliminarmulta.DataSource = multa.rescata_Multas();
            grillaeliminarmulta.DataMember = "Multa";
            grillaeliminarmulta.Columns["Rut_Vendedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Motivo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Detalle_Multa"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Fecha"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Rut_Vendedor"].Width = 150;
            grillaeliminarmulta.Columns["Motivo"].Width = 200;
            grillaeliminarmulta.Columns["Detalle_Multa"].Width = 300;
            grillaeliminarmulta.Columns["Monto"].Width = 100;
            grillaeliminarmulta.Columns["Fecha"].Width = 100;
            inicializarCheckbox();

        }

        private void btcargaconsultamulta_Click(object sender, EventArgs e)
        {
            gbagregarmulta.Visible = false;
            gbeliminarmulta.Visible = false;
            gbconsultarMulta.Visible = true;
        }

        private void btagregarmulta_Click(object sender, EventArgs e)
        {

            if (txtrutvendedoragrega.Text == "" || txtMotivoMultaagrega.Text == "" || txtdescripcionmultaagrega.Text == "" || txtmontomultaagrega.Text == "")
            {
                MessageBox.Show("Debes ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtrutvendedoragrega.Text != "")
            {
                DataSet verificarut = multa.rescata_vendedores(txtrutvendedoragrega.Text);
                if (verificarut.Tables["Vendedor"].Rows.Count > 0)
                {
                    multa.Agregar_multa(txtrutvendedoragrega.Text, txtMotivoMultaagrega.Text, txtdescripcionmultaagrega.Text, int.Parse(txtmontomultaagrega.Text), DateTime.Now.ToShortDateString(), rutusuario);
                    MessageBox.Show("Operación realizada ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtrutvendedoragrega.Clear();
                    txtMotivoMultaagrega.Clear();
                    txtdescripcionmultaagrega.Clear();
                    txtmontomultaagrega.Clear();
                }
                else
                {
                    MessageBox.Show("No existe un vendedor registrado con ese rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btbuscarmultaelim_Click(object sender, EventArgs e)
        {
            if (txtbuscarruteliminar.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del Vendedor a Buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = multa.buscar_multa(txtbuscarruteliminar.Text);
                if (ds.Tables["Multa"].Rows.Count > 0)
                {
                    grillaeliminarmulta.DataSource = multa.buscar_multa(txtbuscarruteliminar.Text);
                    grillaeliminarmulta.DataMember = "Multa";
                    grillaeliminarmulta.Columns["Rut_Vendedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarmulta.Columns["Motivo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarmulta.Columns["Detalle_Multa"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarmulta.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarmulta.Columns["Fecha"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaeliminarmulta.Columns["Rut_Vendedor"].Width = 150;
                    grillaeliminarmulta.Columns["Motivo"].Width = 200;
                    grillaeliminarmulta.Columns["Detalle_Multa"].Width = 300;
                    grillaeliminarmulta.Columns["Monto"].Width = 100;
                    grillaeliminarmulta.Columns["Fecha"].Width = 100;
                    inicializarCheckbox();
                }
                else
                {
                    MessageBox.Show("No existe un Vendedor con ese rut","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btelimmulta_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grillaeliminarmulta.RowCount; i++)
            {
                if (grillaeliminarmulta[0, i].Value.ToString() == "true")
                {
                    multa.Eliminar_Multa(grillaeliminarmulta[1, i].Value.ToString());
                }
            }
            MessageBox.Show("Multa Eliminada Corectamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            grillaeliminarmulta.DataSource = multa.rescata_Multas();
            grillaeliminarmulta.DataMember = "Multa";
            grillaeliminarmulta.Columns["Rut_Vendedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Motivo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Detalle_Multa"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Fecha"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaeliminarmulta.Columns["Rut_Vendedor"].Width = 150;
            grillaeliminarmulta.Columns["Motivo"].Width = 200;
            grillaeliminarmulta.Columns["Detalle_Multa"].Width = 300;
            grillaeliminarmulta.Columns["Monto"].Width = 100;
            grillaeliminarmulta.Columns["Fecha"].Width = 100;
            inicializarCheckbox();
        }

        private void btconsultarmulta_Click(object sender, EventArgs e)
        {
            if (txtrutmultaconsultar.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del Vendedor a Buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = multa.buscar_multa(txtrutmultaconsultar.Text);
                if (ds.Tables["Multa"].Rows.Count > 0)
                {
                    grilllaconsultarmulta.DataSource = multa.buscar_multa(txtrutmultaconsultar.Text);
                    grilllaconsultarmulta.DataMember = "Multa";
                    grilllaconsultarmulta.Columns["Rut_Vendedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilllaconsultarmulta.Columns["Motivo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilllaconsultarmulta.Columns["Detalle_Multa"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilllaconsultarmulta.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilllaconsultarmulta.Columns["Fecha"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilllaconsultarmulta.Columns["Rut_Vendedor"].Width = 150;
                    grilllaconsultarmulta.Columns["Motivo"].Width = 200;
                    grilllaconsultarmulta.Columns["Detalle_Multa"].Width = 300;
                    grilllaconsultarmulta.Columns["Monto"].Width = 100;
                    grilllaconsultarmulta.Columns["Fecha"].Width = 100;
                    inicializarCheckbox();
                }
                else
                {
                    MessageBox.Show("No existe un Vendedor con ese rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btvolvermenuprincipalmulta_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Show();
            principal.Show();
        }
    }
}