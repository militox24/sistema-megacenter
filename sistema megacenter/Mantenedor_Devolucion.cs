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
    public partial class Mantenedor_Devolucion : Form
    {
        Gestion_devolucion devolucion = new Gestion_devolucion();
        string Producto;
        public Mantenedor_Devolucion()
        {
            InitializeComponent();
        }

        private void btcargaagregadevolucion_Click(object sender, EventArgs e)
        {
            gbagregardevolucion.Visible = true;
            gbconsultardevolucion.Visible = false;
        }

        private void btcargaconsulatrdevolucion_Click(object sender, EventArgs e)
        {
            gbagregardevolucion.Visible = false;
            gbconsultardevolucion.Visible = true;

        }

        private void btbuscarventa_Click_1(object sender, EventArgs e)
        {
            if (txtnumeroventadevolucion.Text == "")
            {
                MessageBox.Show("debes ingresar el numero de boleta");
            }
            else
            {
                DataSet verifica = devolucion.buscar_venta(int.Parse(txtnumeroventadevolucion.Text));
                if (verifica.Tables["Detalle_Venta"].Rows.Count > 0)
                {
                    grilladevolucion.DataSource = devolucion.buscar_venta(int.Parse(txtnumeroventadevolucion.Text));
                    grilladevolucion.DataMember = "Detalle_Venta";
                    txtnumeroventadevolucion.Clear();
                }
                else
                {
                    MessageBox.Show("No existe una venta registrada con ese numero de boleta en el sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumeroventadevolucion.Clear();
                }

            }
        }

        private void grilladevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(grilladevolucion[0,0].Value.ToString());
        }
    }
}
