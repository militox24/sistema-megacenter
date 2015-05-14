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
    public partial class Mantenedor_Cambio_Clave : Form
    {
        string rutlogueo;
        string usuariologueo;
        public Mantenedor_Cambio_Clave(string rut,string usuario)
        {
            InitializeComponent();
            rutlogueo = rut;
            usuariologueo = usuario;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void txtnuevaclave_TextChanged(object sender, EventArgs e)
        {
            if(txtnuevaclave.Text==""){
                label3.Visible = false;
                label4.Visible = false;
            }
            if( txtnuevaclave.TextLength>0 && txtnuevaclave.TextLength<=4){
                label3.Text = "Baja";
                label3.ForeColor = Color.DarkRed;
                label3.Visible = true;
                label4.Visible = true;
                
            }
            if(txtnuevaclave.TextLength>=5 && txtnuevaclave.TextLength<8){
                label3.Text = "Media";
                label3.ForeColor = Color.Yellow;
                label3.Visible = true;
                label4.Visible = true;
            }
            if (txtnuevaclave.TextLength >9)
            {
                label3.Text = "Alta";
                label3.ForeColor = Color.DarkOrange;
                label3.Visible = true;
                label4.Visible = true;
            }

        }

        private void BtModificarclave_Click(object sender, EventArgs e)
        {
            if (txtnuevaclave.Text == "" && txtrepetirclave.Text == "")
            {
                MessageBox.Show("Debes ingresar todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtnuevaclave.Text != txtrepetirclave.Text)
                {
                    MessageBox.Show("Las Claves escritas no coinciden.Vuelva a escribir la nueva clave en los dos cuadros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Gestion_Ingreso ingreso = new Gestion_Ingreso();
                    ingreso.modificarClave(txtnuevaclave.Text,usuariologueo,rutlogueo);
                    MessageBox.Show("Modificación realizada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnuevaclave.Clear();
                    txtrepetirclave.Clear();
                    
                }
            }
        }
    }
}
