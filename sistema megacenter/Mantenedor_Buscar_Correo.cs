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
    public partial class Mantenedor_Buscar_Correo : Form
    {
        Gestion_Vendedor vendedor = new Gestion_Vendedor();
        Gestion_Proveedor proveedor = new Gestion_Proveedor();
        Gestion_perfil perfil = new Gestion_perfil();
        //en perfil esta la información del administrador//
        public string correousuario { set; get; }
        
        public Mantenedor_Buscar_Correo()
        {
            InitializeComponent();
            inicializarCheckbox();
        }

        private void cbcargaperfiles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbcargaperfiles.Text == "Vendedor")
            {
                grillaconsultadatoscorreo.DataSource = vendedor.rescatardatosvendedores2();
                grillaconsultadatoscorreo.DataMember = "Vendedor";
                grillaconsultadatoscorreo.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultadatoscorreo.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultadatoscorreo.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultadatoscorreo.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grillaconsultadatoscorreo.Columns["Nombres"].Width = 150;
                grillaconsultadatoscorreo.Columns["Apellidos"].Width = 200;
                grillaconsultadatoscorreo.Columns["Correo"].Width = 250;
                inicializarCheckbox();
                label2.Visible = false; ;
                txtconsultacorreo.Clear();
                txtconsultacorreo.Visible = false;
                btbuscarcorreo.Visible = false;
                grillaconsultadatoscorreo.Visible = true;
                Grillaconsultacorreo2.Visible = false;
                label3.Visible = false;
                cbtipo.Visible = false;

            }
            else
            {
                if (cbcargaperfiles.Text == "Administrador")
                {
                    grillaconsultadatoscorreo.DataSource = perfil.rescatartodoslosadministradores();
                    grillaconsultadatoscorreo.DataMember = "Administrador";
                    grillaconsultadatoscorreo.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultadatoscorreo.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultadatoscorreo.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultadatoscorreo.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grillaconsultadatoscorreo.Columns["Nombres"].Width = 150;
                    grillaconsultadatoscorreo.Columns["Apellidos"].Width = 200;
                    grillaconsultadatoscorreo.Columns["Correo"].Width = 250;
                    inicializarCheckbox();
                    label2.Visible = false; ;
                    txtconsultacorreo.Clear();
                    txtconsultacorreo.Visible = false;
                    btbuscarcorreo.Visible = false;
                    grillaconsultadatoscorreo.Visible = true;
                    Grillaconsultacorreo2.Visible = false;
                    label3.Visible = false;
                    cbtipo.Visible = false;
                }
                else
                {
                    if (cbcargaperfiles.Text == "Proveedor")
                    {
                        grillaconsultadatoscorreo.DataSource = proveedor.rescatadatosdeproveedores();
                        grillaconsultadatoscorreo.DataMember = "Proveedor";
                        grillaconsultadatoscorreo.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        grillaconsultadatoscorreo.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        grillaconsultadatoscorreo.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        grillaconsultadatoscorreo.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        grillaconsultadatoscorreo.Columns["Nombres"].Width = 150;
                        grillaconsultadatoscorreo.Columns["Descripcion"].Width = 200;
                        grillaconsultadatoscorreo.Columns["Email"].Width = 250;
                        inicializarCheckbox();
                        label2.Visible = false; ;
                        txtconsultacorreo.Clear();
                        txtconsultacorreo.Visible = false;
                        btbuscarcorreo.Visible = false;
                        grillaconsultadatoscorreo.Visible = true;
                        Grillaconsultacorreo2.Visible = false;
                        label3.Visible = false;
                        cbtipo.Visible = false;
                    }
                    else
                    {
                        if (cbcargaperfiles.Text == "Otro Filtro Busqueda")
                        {
                            label2.Visible = true; 
                            txtconsultacorreo.Visible = true;
                            btbuscarcorreo.Visible = true;
                            grillaconsultadatoscorreo.Visible = false;
                            Grillaconsultacorreo2.Visible = true;
                            label3.Visible = true;
                            cbtipo.Visible = true;
                        }

                    }
                }
            }
        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillaconsultadatoscorreo.RowCount; i++)
            {
                grillaconsultadatoscorreo[1, i].ReadOnly = true;
                grillaconsultadatoscorreo[2, i].ReadOnly = true;
                grillaconsultadatoscorreo[3, i].ReadOnly = true;
                grillaconsultadatoscorreo[4, i].ReadOnly = true;
                grillaconsultadatoscorreo[0, i].Value = false;
                grillaconsultadatoscorreo[0, i].ReadOnly = false;
            }
            for (int i = 0; i < Grillaconsultacorreo2.RowCount; i++)
            {
                Grillaconsultacorreo2[1, i].ReadOnly = true;
                Grillaconsultacorreo2[2, i].ReadOnly = true;
                Grillaconsultacorreo2[3, i].ReadOnly = true;
                Grillaconsultacorreo2[4, i].ReadOnly = true;
                Grillaconsultacorreo2[0, i].Value = false;
                Grillaconsultacorreo2[0, i].ReadOnly = false;
            }
        }

        private void btbuscarcorreo_Click(object sender, EventArgs e)
        {
            if (txtconsultacorreo.Text == "" || cbtipo.Text=="Seleccione")
            {
                MessageBox.Show("Faltan campos por completar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbtipo.Text == "Vendedor")
                {
                    DataSet existenciavendedor=vendedor.Buscar_por_nombres(txtconsultacorreo.Text);
                    if (existenciavendedor.Tables["Vendedor"].Rows.Count > 0)
                    {
                        Grillaconsultacorreo2.DataSource = vendedor.Buscar_por_nombres(txtconsultacorreo.Text);
                        Grillaconsultacorreo2.DataMember = "Vendedor";
                        Grillaconsultacorreo2.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        Grillaconsultacorreo2.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        Grillaconsultacorreo2.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        Grillaconsultacorreo2.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                        Grillaconsultacorreo2.Columns["Nombres"].Width = 150;
                        Grillaconsultacorreo2.Columns["Apellidos"].Width = 200;
                        Grillaconsultacorreo2.Columns["Correo"].Width = 250;
                        inicializarCheckbox();
                    }
                    else {
                        MessageBox.Show("No existe un usuario registrado con ese nombre","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (cbtipo.Text == "Administrador")
                    {
                        DataSet existenciaadministrador = perfil.buscar_por_nombres(txtconsultacorreo.Text);
                        if (existenciaadministrador.Tables["Administrador"].Rows.Count > 0)
                        {
                            Grillaconsultacorreo2.DataSource = perfil.buscar_por_nombres(txtconsultacorreo.Text);
                            Grillaconsultacorreo2.DataMember = "Administrador";
                            Grillaconsultacorreo2.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                            Grillaconsultacorreo2.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                            Grillaconsultacorreo2.Columns["Apellidos"].SortMode = DataGridViewColumnSortMode.NotSortable;
                            Grillaconsultacorreo2.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
                            Grillaconsultacorreo2.Columns["Nombres"].Width = 150;
                            Grillaconsultacorreo2.Columns["Apellidos"].Width = 200;
                            Grillaconsultacorreo2.Columns["Correo"].Width = 250;
                            inicializarCheckbox();
                        }
                        else
                        {
                            MessageBox.Show("No existe un usuario registrado con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if(cbtipo.Text=="Proveedor"){
                            DataSet existenciaproveedor = proveedor.buscar_por_nombres(txtconsultacorreo.Text);
                            if (existenciaproveedor.Tables["Proveedor"].Rows.Count > 0)
                            {
                                Grillaconsultacorreo2.DataSource = proveedor.buscar_por_nombres(txtconsultacorreo.Text);
                                Grillaconsultacorreo2.DataMember = "Proveedor";
                                Grillaconsultacorreo2.Columns["Rut"].SortMode = DataGridViewColumnSortMode.NotSortable;
                                Grillaconsultacorreo2.Columns["Nombres"].SortMode = DataGridViewColumnSortMode.NotSortable;
                                Grillaconsultacorreo2.Columns["Descripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
                                Grillaconsultacorreo2.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
                                Grillaconsultacorreo2.Columns["Nombres"].Width = 150;
                                Grillaconsultacorreo2.Columns["Descripcion"].Width = 200;
                                Grillaconsultacorreo2.Columns["Email"].Width = 250;
                                inicializarCheckbox();
                                txtconsultacorreo.Clear();
                                cbtipo.Text = "Seleccione";
                            }
                            else
                            {
                                MessageBox.Show("No existe un usuario registrado con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtconsultacorreo.Clear();
                                cbtipo.Text = "Seleccione";
                            }
                        }
                    }
                }
            }
        }

        private void Grillaconsultacorreo2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            correousuario = Grillaconsultacorreo2.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }

        private void grillaconsultadatoscorreo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            correousuario = grillaconsultadatoscorreo.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void txtconsultacorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚáéíóú " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
