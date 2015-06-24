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
    public partial class Mantenedor_Pago : Form
    {
        Gestion_Pagos pagos = new Gestion_Pagos();
        string nombreusuario, apellidousuario, rutusuario, urlimagen, usuariologueado,correousuario;
        public Mantenedor_Pago(string nombre, string apellido, string rut, string url, string usuario, string correo)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            rutusuario = rut;
            urlimagen = url;
            usuariologueado = usuario;
            correousuario = correo;
        }

        private void inicializarCheckbox()
        {

            for (int i = 0; i < grillapagocliente.RowCount; i++)
            {
                grillapagocliente[1, i].ReadOnly = true;
                grillapagocliente[2, i].ReadOnly = true;
                grillapagocliente[3, i].ReadOnly = true;
                grillapagocliente[4, i].ReadOnly = true;
                grillapagocliente[0, i].Value = false;
                grillapagocliente[0, i].ReadOnly = false;
            }
        }
        private void btbuscarclientepago_Click(object sender, EventArgs e)
        {
            if (txtclientepago.Text == "")
            {
                MessageBox.Show("Debes ingresar el rut del usuario a buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               DataSet verifica=pagos.verificarexistencia(txtclientepago.Text);
               if (verifica.Tables["Cliente"].Rows.Count > 0)
               {
                   DataSet verificaventa = pagos.verificarpagos(txtclientepago.Text);
                   if (verificaventa.Tables["Venta"].Rows.Count > 0)
                   {
                       GrillaInicio.Visible = false;
                       grillapagocliente.Visible = true;
                       grillapagocliente.DataSource = pagos.verificarpagos(txtclientepago.Text);
                       grillapagocliente.DataMember = "Venta";
                       inicializarCheckbox();
                   }
                   else
                   {
                       MessageBox.Show("El cliente no registra pagos pendientes ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
               }
               else
               {
                   MessageBox.Show("No existe un cliente registrado con ese rut ","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
               }
                
            }
        }

        private void txtclientepago_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890-k" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void btpagar_Click(object sender, EventArgs e)
        {
            Boolean estado = false; ;
            for (int i = 0; i < grillapagocliente.RowCount; i++)
            {
                if (grillapagocliente[0, i].Value.ToString() == "true")
                {
                    pagos.modificaestadoventa(int.Parse(grillapagocliente[1, i].Value.ToString()));
                    estado = true;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un pago a realizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                }
            }
            if(estado==true){
                MessageBox.Show("Pago Realizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GrillaInicio.Visible = true;
                grillapagocliente.Visible = false;
                inicializarCheckbox();
                txtclientepago.Clear();
            }
            
        }

        private void btvolvermenuprincipalpago_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado, correousuario);
            this.Hide();
            principal.Show();
        }
    }
}
