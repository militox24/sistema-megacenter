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
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado, correousuario;
        public Mantenedor_Devolucion(string nombre, string apellido, string url, string rut, string usuario,string  correo )
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            urlimagen = url;
            rutusuario = rut;
            usuariologueado = usuario;
            correousuario = correo;
        }

        private void btcargaagregadevolucion_Click(object sender, EventArgs e)
        {
            gbagregardevolucion.Visible = true;
            gbconsultardevolucion.Visible = false;
            grillaconsultadevolucion.Visible = false;
            grillaconsulta2.Visible = true;

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



        private void btbuscardevolucion_Click(object sender, EventArgs e)
        {
            if (txtboletadevolucionconsulta.Text == "")
            {
                MessageBox.Show("debes ingresar el numero de boleta a consultar");
            }
            else
            {
                DataSet ds = devolucion.buscar_devolucion(int.Parse(txtboletadevolucionconsulta.Text));
                if (ds.Tables["Devolucion"].Rows.Count > 0)
                {
                    grillaconsultadevolucion.DataSource = devolucion.buscar_devolucion(int.Parse(txtboletadevolucionconsulta.Text));
                    grillaconsultadevolucion.DataMember = "Devolucion";
                    grillaconsulta2.Visible = false;
                    grillaconsultadevolucion.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay devoluciones registradas con ese numero de boleta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboletadevolucionconsulta.Clear();
                }


            }

        }

        private void grilladevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Fila" + e.RowIndex + "" + "columna" + e.ColumnIndex);

            if (e.ColumnIndex == 0)
            {
                txtproducto.Text = grilladevolucion[2, e.RowIndex].Value.ToString();
                txtcantidad.Text = grilladevolucion[1, e.RowIndex].Value.ToString();
            }
        }

        private void btdevolver_Click(object sender, EventArgs e)
        {
            if (txtproducto.Text == "" || txtcantidad.Text == "")
            {
                MessageBox.Show("Debes seleccionar el producto a devolver", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtunidadesdevueltas.Text == "" || txtmotivodevolucion.Text == "")
                {
                    MessageBox.Show("Debes ingresar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DataSet cantidadrestante = devolucion.rescata_unidades(txtproducto.Text);
                    if (cantidadrestante.Tables["Devolucion"].Rows.Count > 0)
                    {
                        int cantidadrestante1 = int.Parse(cantidadrestante.ToString()) - int.Parse(txtcantidad.Text);
                        MessageBox.Show("" + cantidadrestante1);
                        if (int.Parse(txtunidadesdevueltas.Text) > cantidadrestante1)
                        {

                            MessageBox.Show("La cantidad devuelta debe ser menor a la cantidad vendida");
                        }
                        else
                        {
                            devolucion.Agregar_devolucion(txtproducto.Text, int.Parse(txtunidadesdevueltas.Text), txtmotivodevolucion.Text, DateTime.Now.ToShortDateString(), int.Parse(txtnumeroventadevolucion.Text));
                            txtnumeroventadevolucion.Clear();
                            txtproducto.Clear();
                            txtcantidad.Clear();
                            txtmotivodevolucion.Clear();
                            txtunidadesdevueltas.Clear();
                        }


                    }
                }
            }




        }

        private void btvolvermenuprincipaladministrador1_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado, correousuario);
            this.Hide();
            principal.Show();
        }
    }
}
