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
    public partial class Ingreso_Sistema : Form
    {
        public string usuariologueado;
        public string nombres;
        public string apellidos;
        public string url;
        public Ingreso_Sistema(string usuario)
        {
            InitializeComponent();
            usuariologueado = usuario;
            
        }

        private void Ingreso_Sistema_Load(object sender, EventArgs e)
        {

        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Interfaz_Inicial inicio = new Interfaz_Inicial();
            this.Close();
            inicio.Show();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            string errores = "";
            if (txtrutingreso.Text == "")
            {
                errores = errores + "Debes Ingresar el Rut\n";
            }
            
            if(txtclaveingreso.Text==""){
                errores = errores + "Debes Ingresar la clave\n";
            }


            if (errores != "")
            {
                MessageBox.Show("" + errores + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gestion_Ingreso ingreso = new Gestion_Ingreso();
                if (usuariologueado == "Administrador")
                {
                    DataSet ds = ingreso.Ingreso_Sistema(txtrutingreso.Text, txtclaveingreso.Text, usuariologueado);
                    if (ds.Tables["" + usuariologueado + ""].Rows.Count > 0)
                    {
                        nombres = ds.Tables["" + usuariologueado + ""].Rows[0][1].ToString();
                        apellidos = ds.Tables["" + usuariologueado + ""].Rows[0][2].ToString();
                        url = ds.Tables["" + usuariologueado + ""].Rows[0][11].ToString();
                        this.Hide();
                        Menu_Principal menu = new Menu_Principal(nombres, apellidos, url, txtrutingreso.Text);
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Los datos solicitados no son validos");
                    }
                }
                else
                {
                    DataSet ds1 = ingreso.Ingreso_Sistema(txtrutingreso.Text, txtclaveingreso.Text, usuariologueado);
                    if (ds1.Tables["" + usuariologueado + ""].Rows.Count > 0)
                    {
                        nombres = ds1.Tables["" + usuariologueado + ""].Rows[0][1].ToString();
                        apellidos = ds1.Tables["" + usuariologueado + ""].Rows[0][2].ToString();
                        url = ds1.Tables["" + usuariologueado + ""].Rows[0][14].ToString();
                        this.Hide();
                        Menu_Vendedor menu2 = new Menu_Vendedor(nombres, apellidos, url);
                        menu2.Show();
                    }
                    else
                    {
                        MessageBox.Show("los datos no son validos");
                    }
                }
            }
        }

        private void txtrutingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recupera_Contraseña contraseña = new Recupera_Contraseña(usuariologueado);
            this.Hide();
            contraseña.Show();
        }
    }
}
