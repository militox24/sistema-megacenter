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
    public partial class Mantenedor_Giro : Form
    {
        Gestion_Giro gestion = new Gestion_Giro();
        string nombreusuario, apellidousuario, rutusuario, urlimagen,usuariologueado;
        public Mantenedor_Giro(string nombre,string apellido,string rut,string url,string usuario)
        {
            InitializeComponent();
            label4.Text = "0";
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            usuariologueado = usuario;
            urlimagen = url;
        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillagiros.RowCount; i++)
            {
                grillagiros[1, i].ReadOnly = true;
                grillagiros[2, i].ReadOnly = true;
                grillagiros[0, i].Value = false;
                grillagiros[0, i].ReadOnly = false;
            }
        }
        private void btcargaagregagiro_Click(object sender, EventArgs e)
        {
            gbagregagiro.Visible = true;
            gbeliminagiro.Visible = false;
        }

        private void btcargaeliminagiro_Click(object sender, EventArgs e)
        {
            gbagregagiro.Visible = false;
            gbeliminagiro.Visible = true;
            grillagiros.DataSource = gestion.rescatar_giros();
            grillagiros.DataMember = "Giro";
            grillagiros.Columns["Nombre_Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillagiros.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillagiros.Columns["Nombre_Giro"].Width = 130;
            grillagiros.Columns["Descripcion"].Width = 250;
           
            inicializarCheckbox();

        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú, " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdescripciongiro_TextChanged(object sender, EventArgs e)
        {
            label4.Text = txtdescripciongiro.TextLength.ToString();
        }

        private void txtgiroagrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdescripciongiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void btagregargiro_Click(object sender, EventArgs e)
        {
            string errores = "Usted tiene los siguientes errores:\n";
            Boolean estado = false;
            if(txtgiroagrega.Text==""||txtdescripciongiro.Text==""){
                errores = errores + "Debes completar todos los campos\n";
                estado = true;
            }
            if(txtgiroagrega.TextLength>40){
                errores = errores + "el giro debe contener menos de 40 carateres\n";
                estado = true;
            }
            if(txtdescripciongiro.TextLength>150){
                errores = errores + "La descripción debe contener menos de 150 carateres\n";
                estado = true;
            }
            if (estado != false)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificaexistencia = gestion.verificar_giro(txtgiroagrega.Text);
                if (verificaexistencia.Tables["Giro"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un registro asociado con ese nombre de giro en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgiroagrega.Clear();
                    txtdescripciongiro.Clear();
                }
                else
                {
                    gestion.registrar_giro(txtgiroagrega.Text,txtdescripciongiro.Text);
                    MessageBox.Show("Operación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtgiroagrega.Clear();
                    txtdescripciongiro.Clear();



                }
            }
        }

        private void btbuscargiroelim_Click(object sender, EventArgs e)
        {
            if (txtgiroeliminar.Text == "")
            {
                MessageBox.Show("Debes ingresar el nombre del giro a buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grillagiros.DataSource = gestion.Buscar_giro(txtgiroeliminar.Text);
                grillagiros.DataMember = "Giro";
                inicializarCheckbox();
                grillagiros.Columns["Nombre_Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillagiros.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillagiros.Columns["Nombre_Giro"].Width = 130;
                grillagiros.Columns["Descripcion"].Width = 250;
                txtgiroeliminar.Clear();
            }
        }

        private void btelimgiro_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grillagiros.RowCount; i++)
            {
                if (grillagiros[0, i].Value.ToString() == "true")
                {
                    gestion.Elimina_Giro(grillagiros[1, i].Value.ToString());
                }

            }
            MessageBox.Show("Giro Eliminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grillagiros.DataSource = gestion.rescatar_giros();
            grillagiros.DataMember = "Giro";
            grillagiros.Columns["Nombre_Giro"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillagiros.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillagiros.Columns["Nombre_Giro"].Width = 130;
            grillagiros.Columns["Descripcion"].Width = 250;
            
        }

        private void btvolvermenuprincipal2_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();
        }
    }
}
