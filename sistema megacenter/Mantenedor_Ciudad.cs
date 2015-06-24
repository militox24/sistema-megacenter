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
 
    public partial class Mantenedor_Ciudad : Form
    {
        string nombreusuario;
        string apellidousuario;
        string urlimagen;
        string rutusuario;
        string usuariologueado;
        string correologueado;
        Gestión_Ciudad gestion = new Gestión_Ciudad();
        public Mantenedor_Ciudad(string nombre, string apellido,string ruta_foto,string rut,string usuario,string correo)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = ruta_foto;
            usuariologueado = usuario;
            correologueado = correo;
            if (usuariologueado == "Administrador")
            {
                btvolvermenu.Visible = true;
            }
            else
            {
                btvolvermenuprincipalvendedor.Visible = true;
            }
        }
        private void inicializarCheckbox()
        {

            for (int i = 0; i < grilla.RowCount; i++)
            {
                grilla[1, i].ReadOnly = true;
                grilla[2, i].ReadOnly = true;
                grilla[0, i].Value = false;
                grilla[0, i].ReadOnly = false;
            }
        }

        private void btagregaciudad_Click(object sender, EventArgs e)
        {
            gbagregaciudad.Visible = true;
            gbeliminaciudad.Visible = false;
            gbmodificaciudad.Visible = false;

        }

        private void bteliminaciudad_Click(object sender, EventArgs e)
        {
            gbagregaciudad.Visible = false;
            gbeliminaciudad.Visible = true;
            gbmodificaciudad.Visible = false;
            grilla.DataSource = gestion.rescatardatosciudad();
            grilla.DataMember = "Ciudad";
            grilla.Columns["Nombre_Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grilla.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grilla.Columns["Nombre_Ciudad"].Width = 150;
            grilla.Columns["Descripción"].Width = 200;
            inicializarCheckbox();
        }

        private void btmodificaciudad_Click(object sender, EventArgs e)
        {
            gbagregaciudad.Visible = false;
            gbeliminaciudad.Visible = false;
            gbmodificaciudad.Visible = true;
        }

        private void btagregarciudad_Click(object sender, EventArgs e)
        {
            if (txtnombreciudad.Text == "" || txtdescripcionciudad.Text == "")
            {
                MessageBox.Show("Debes Ingresar los campos solicitados","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = gestion.verificarciudad(txtnombreciudad.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Actualmente se encuentra registrada esa ciudad en el sistema");
                    txtnombreciudad.Clear();
                    txtdescripcionciudad.Clear();
                }
                else
                {
                    gestion.insertarCiudad(txtnombreciudad.Text, txtdescripcionciudad.Text);
                    MessageBox.Show("Operación realizada con exito");
                    txtnombreciudad.Clear();
                    txtdescripcionciudad.Clear();
                }
            }
        }

        private void txtnombreciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdescripcionciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdescripcionciudad_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripcionciudad.TextLength == 0)
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
                label4.Text = txtdescripcionciudad.TextLength.ToString();
            }
        }

        private void btbuscarelimciudad_Click(object sender, EventArgs e)
        {
            if (txtciudadeliminar.Text == "")
            {
                MessageBox.Show("debes ingresar el nombre de la ciudad a eliminar");
            }
            else
            {
                DataSet ds = gestion.Buscar_Ciudad(txtciudadeliminar.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    grilla.DataSource = gestion.Buscar_Ciudad(txtciudadeliminar.Text);
                    grilla.DataMember = "Ciudad";
                    grilla.Columns["Nombre_Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilla.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
                    grilla.Columns["Nombre_Ciudad"].Width = 150;
                    grilla.Columns["Descripción"].Width = 200;
                }
                else
                {
                    MessageBox.Show("No existe una ciudad con ese nombre registrado en el sistema","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
            }
        }

        private void beliminarciudad_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            for (int i = 0; i < grilla.RowCount; i++)
            {
                if (grilla[0, i].Value.ToString() == "true")
                {
                    gestion.Elimina_ciudad(grilla[1, i].Value.ToString());
                    estado = true;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar la ciudad a eliminar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    estado = false;
                }
            }

            if(estado==true){
                MessageBox.Show("Ciudad Eliminada Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grilla.DataSource = gestion.rescatardatosciudad();
                grilla.DataMember = "Ciudad";
                inicializarCheckbox();
                grilla.Columns["Nombre_Ciudad"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grilla.Columns["Descripción"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grilla.Columns["Nombre_Ciudad"].Width = 150;
                grilla.Columns["Descripción"].Width = 200;   
            }
              
        }

        private void txtdescripcionciudadmodifica_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripcionciudadmodifica.TextLength == 0)
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
                label9.Text = txtdescripcionciudadmodifica.TextLength.ToString();
            }
        }

        private void btmodificarciudad_Click(object sender, EventArgs e)
        {
            if (txtciudadmodifica.Text == "" || txtdescripcionciudadmodifica.Text == ""||txtnuevonombreciudad.Text=="")
            {
                MessageBox.Show("Debes Ingresar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds=gestion.Buscar_Ciudad(txtnuevonombreciudad.Text);
                if (ds.Tables["Ciudad"].Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe una ciudad registrada en el sistema con ese nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gestion.modificadatosciudad(txtciudadmodifica.Text, txtdescripcionciudadmodifica.Text, txtnuevonombreciudad.Text);
                    MessageBox.Show("Modificación realizada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtciudadmodifica.Clear();
                    txtdescripcionciudadmodifica.Clear();
                    txtdescripcionciudadmodifica.Enabled = false;
                    txtnuevonombreciudad.Visible = false;
                    label10.Visible = false;

                    txtciudadmodifica.Enabled = true;
                    btmodificarciudad.Visible = false;
                }
            }
        }

        private void btbuscarciudad_Click(object sender, EventArgs e)
        {
            if (txtciudadmodifica.Text == "")
            {
                MessageBox.Show("Debes ingresar el nombre de la ciudad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds1 = gestion.Buscar_Ciudad(txtciudadmodifica.Text);
                if (ds1.Tables["Ciudad"].Rows.Count != 0)
                {
                    txtdescripcionciudadmodifica.Enabled = true;
                    btmodificarciudad.Visible = true;
                    label10.Visible = true;
                    txtciudadmodifica.Enabled = false;
                    txtnuevonombreciudad.Visible = true;
                    txtdescripcionciudadmodifica.Text = ds1.Tables["Ciudad"].Rows[0][1].ToString();
                    txtciudadmodifica.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe una ciudad registrada con ese nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btvolvermenu_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal(nombreusuario, apellidousuario, urlimagen, rutusuario,usuariologueado,correologueado);
            this.Hide();
            menu.Show();
        }

        private void btvolvermenuprincipalvendedor_Click(object sender, EventArgs e)
        {
            Menu_Vendedor menu = new Menu_Vendedor(nombreusuario, apellidousuario, urlimagen, rutusuario,usuariologueado,correologueado);
            this.Hide();
            menu.Show();
        }

        private void txtciudadeliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtciudadmodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnuevonombreciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdescripcionciudadmodifica_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = " qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÓÚáéíóú,." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
