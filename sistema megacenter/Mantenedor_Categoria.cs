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
    public partial class Mantenedor_Categoria : Form
    {
        string nombreusuario, apellidousuario, rutusuario, urlimagen,correousuario,usuariologueado;
        int id_categoria;
        Gestion_Categoria gestion = new Gestion_Categoria();
        public Mantenedor_Categoria(string nombre, string apellido, string rut,string url,string usuario,string correo)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado=usuario;
            correousuario = correo;
        }

        private void cargaagrecategoria_Click(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = true;
            gbelimcategoria.Visible = false;
            gbmodificacategoria.Visible = false;


        }

       

     
        private void btagregarcategoria_Click(object sender, EventArgs e)
        {
            if (txtcateagre.Text == "" || txtdescripacatgre.Text == "")
            {
                MessageBox.Show("Debes completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificaexistenciacategoria = gestion.verificarcategoria(txtcateagre.Text);
                if (verificaexistenciacategoria.Tables["Categoria"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe una categoria registrada con ese nombre en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcateagre.Clear();
                    txtdescripacatgre.Clear();
                }
                else
                {
                    gestion.insertarCategoria(txtcateagre.Text,txtdescripacatgre.Text);
                    MessageBox.Show("Categoria Agregada con exito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtcateagre.Clear();
                    txtdescripacatgre.Clear();
                }
            }
        }

        private void Cargaelimcategoria_Click_1(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = false;
            gbelimcategoria.Visible = true;
            gbmodificacategoria.Visible = false;
            grillaelimcategoria.DataSource = gestion.rescatardatoscategorias();
            grillaelimcategoria.DataMember = "Categoria";
            grillaelimcategoria.Columns["Nombre_Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcategoria.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grillaelimcategoria.Columns["Nombre_Categoria"].Width = 150;
            grillaelimcategoria.Columns["Descripción"].Width = 200;
            inicializarCheckbox();
        }

        private void cargamodicategoria_Click(object sender, EventArgs e)
        {
            gbagrecategoria.Visible = false;
            gbelimcategoria.Visible = false;
            gbmodificacategoria.Visible = true;

        }
        private void inicializarCheckbox()
        {
            for (int i = 0; i < grillaelimcategoria.RowCount; i++)
            {
                grillaelimcategoria[1, i].ReadOnly = true;
                grillaelimcategoria[2, i].ReadOnly = true;
                grillaelimcategoria[0, i].Value = false;
                grillaelimcategoria[0, i].ReadOnly = false;
            }
        }
        private void Omitir_Caracteres(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcateagre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdescripacatgre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void btbuscarcategoriaelim_Click(object sender, EventArgs e)
        {
            if (txtbuscarcategoria.Text == "")
            {
                MessageBox.Show("debes ingresar el nombre de la categoria");
            }
            else
            {
                DataSet verifica = gestion.verificarcategoria(txtbuscarcategoria.Text);
                if (verifica.Tables["Categoria"].Rows.Count > 0)
                {
                    grillaelimcategoria.DataSource = gestion.verificarcategoria(txtbuscarcategoria.Text);
                    grillaelimcategoria.DataMember = "Categoria";
                    grillaelimcategoria.Columns["Nombre_Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcategoria.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaelimcategoria.Columns["Nombre_Categoria"].Width = 150;
                    grillaelimcategoria.Columns["Descripción"].Width = 200;
                    txtbuscarcategoria.Clear();
                }
                else
                {
                    MessageBox.Show("No existe una categoria con ese nombre registrada en el sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbuscarcategoria.Clear();
                }
               
            }
        }

        private void txtbuscarcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtcategoriamodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void txtdescripcionmodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        private void btbuscarcategoriamodifica_Click(object sender, EventArgs e)
        {
            if (txtcategoriamodifica.Text == "")
            {
                MessageBox.Show("Debes ingresar el nombre de la categoria");
            }
            else
            {
                DataSet verifica = gestion.verificarcategoria(txtcategoriamodifica.Text);
                if (verifica.Tables["Categoria"].Rows.Count > 0)
                {
                    id_categoria = int.Parse(verifica.Tables["Categoria"].Rows[0][0].ToString());
                    txtdescripcionmodifica.Text = verifica.Tables["Categoria"].Rows[0][2].ToString();
                    btmodificarcategoria.Visible = true;
                    txtdescripcionmodifica.Enabled = true;
                    txtnuevonombre.Enabled = true;
                    txtcategoriamodifica.Enabled = false;
                    
                }
                else
                {
                    MessageBox.Show("No existe una categoria con ese nombre registrada en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscarcategoria.Clear();
                }

            }
        }

        private void btmodificarcategoria_Click(object sender, EventArgs e)
        {
            if(txtcategoriamodifica.Text==""|| txtdescripcionmodifica.Text==""||txtnuevonombre.Text==""){
                MessageBox.Show("Faltan campos por completar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else{
                    gestion.modificadatoscategoria(txtcategoriamodifica.Text,txtdescripcionmodifica.Text,txtnuevonombre.Text);
                    MessageBox.Show("Operación realizada con exito","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtcategoriamodifica.Enabled = true;
                    txtnuevonombre.Enabled = false;
                    txtdescripcionmodifica.Enabled = false;
                    btmodificarcategoria.Visible = false;
                    txtcategoriamodifica.Clear();
                    txtnuevonombre.Clear();
                    txtdescripcionmodifica.Clear();

            }
            }

        private void btelimcategoria_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            
            for (int i = 0; i < grillaelimcategoria.RowCount; i++)
            {
                if (grillaelimcategoria[0, i].Value.ToString() == "true")
                {
                    gestion.Eliminar_Categoria(grillaelimcategoria[1, i].Value.ToString());
                    estado = true;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la categoria a eliminar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    estado = false;
                }
            }
            if (estado == true)
            {
                MessageBox.Show("Categoria Eliminada Correctamente");
                grillaelimcategoria.DataSource = gestion.rescatardatoscategorias();
                grillaelimcategoria.DataMember = "Categoria";
                inicializarCheckbox();
                grillaelimcategoria.Columns["Nombre_Categoria"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcategoria.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaelimcategoria.Columns["Nombre_Categoria"].Width = 150;
                grillaelimcategoria.Columns["Descripción"].Width = 200;
            }
        }

        private void btcancelarcategoria_Click(object sender, EventArgs e)
        {
            txtcategoriamodifica.Enabled = true;
            txtnuevonombre.Enabled = false;
            txtdescripcionmodifica.Enabled = false;
            btmodificarcategoria.Visible = false;
            txtcategoriamodifica.Clear();
            txtnuevonombre.Clear();
            txtdescripcionmodifica.Clear();
        }

        private void btvolvermenuprincipalcategoria_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado,correousuario);
            this.Hide();
            principal.Show();
        }

        private void txtnuevonombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Omitir_Caracteres(sender,e);
        }

        
        }

    }

