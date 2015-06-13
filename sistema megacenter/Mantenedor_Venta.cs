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
    public partial class Mantenedor_Venta : Form
    {
       // string errores = "";
        int codigo, cantidad, subtotal, valorunitario,  totales, cantidad3, codigo3, valorunitario3, subtotal3, n_compra;
        string nombre, precio, rut_administrador;
       // bool estado = false;
        int neto, iva, suma, stockproducto;
       // bool bandera = false;
       // int resta = 0;
        Gestion_venta venta = new Gestion_venta();
        //gestionproducto gestion1 = new gestionproducto();
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado;
        public Mantenedor_Venta(string nombre,string  apellido,string url,string rut,string usuario)
        {
            InitializeComponent();
            txtrutadministrador.Text = rut;
            nombreusuario = nombre;
            apellidousuario = apellido;
            urlimagen = url;
            rutusuario = rut;
            usuariologueado = usuario;
            if (usuariologueado == "Administrador")
            {
                label14.Text = "Rut Administrador";
                btmenuprincipalventa.Visible = true;
            }
            else
            {
                label14.Text = "Rut Vendedor";
                btvolvermenuvendedorventa.Visible = true;

            }

            txtfechaventa.Text = DateTime.Now.ToShortDateString();
        }

        private void Mantenedor_Venta_Load(object sender, EventArgs e)
        {
            txtventa.Text = Convert.ToString(1 + int.Parse(venta.TraerValor("select isnull(max(N_Venta),0) from Venta")));
            inicializarCheckbox();
        }
        private void inicializarCheckbox()
        {
            for (int i = 0; i < grilladetalleventa.RowCount; i++)
            {
                grilladetalleventa[0, i].ReadOnly = true;
                grilladetalleventa[1, i].ReadOnly = true;
                grilladetalleventa[2, i].ReadOnly = true;
                grilladetalleventa[3, i].ReadOnly = true;
                grilladetalleventa[4, i].ReadOnly = true;
            }
        }
        private void CalcularTotales(int Total)
        {
            txttotalventa.Text = Total.ToString();
            txtnetoventa.Text = Math.Round((Total / 1.19), 0).ToString();
            txtivaventa.Text = Math.Round((Total - (Total / 1.19)), 0).ToString();
        }
        private string isnull(string cadena)
        {
            if (cadena == "")
                cadena = "0";
            return cadena;
        }

        private void grilladetalleventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("fila:" + e.RowIndex + "\ncolomna:" + e.ColumnIndex);
            if (e.ColumnIndex == 4)
            {
                DialogResult dr;
                dr = MessageBox.Show("Esta seguro que desea ELIMINAR los datos", "Ventana de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            int totalfinal = 0;
                            int.TryParse(txttotalventa.Text, out totalfinal);
                            int.TryParse(grilladetalleventa.Rows[e.RowIndex].Cells[3].Value.ToString(), out subtotal);
                            totalfinal = totalfinal - subtotal;
                            CalcularTotales(totalfinal);
                            grilladetalleventa.Rows.RemoveAt(e.RowIndex);

                            MessageBox.Show("Los datos de ELIMINARON correctamente", "Respuesta de Operación");

                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }

        }

        private void btagregarventa_Click(object sender, EventArgs e)
        {
            if (txtcodigoproductoventa.Text != "" && txtcantidadventa.Text != "")
            {

                int.TryParse(txtcodigoproductoventa.Text, out codigo);
                DataSet ds = venta.informacion_productos(codigo);
                int existe = ds.Tables["Producto"].Rows.Count;
                if (existe != 0)
                {
                    nombre = ds.Tables["Producto"].Rows[0][0].ToString();
                    precio = ds.Tables["Producto"].Rows[0][1].ToString();
                    int.TryParse(precio, out valorunitario);
                    int.TryParse(txtcantidadventa.Text, out cantidad);
                    subtotal = cantidad * valorunitario;
                    grilladetalleventa.Rows.Add(cantidad, nombre, precio, subtotal);
                    txtcantidadventa.Clear();
                    txtcodigoproductoventa.Clear();
                }
                else
                {
                    MessageBox.Show("no hay ningun registro asociado a ese codigo de producto");
                }

            }
            else
            {
                MessageBox.Show("ingrese los datos solicitados");
            }
        }

        private void grilladetalleventa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int subtotal;
            int total = 0;
            if (grilladetalleventa.Rows.Count != 0)
            {
                for (int i = 0; i < grilladetalleventa.Rows.Count; i++)
                {

                    int.TryParse(grilladetalleventa.Rows[i].Cells[3].Value.ToString(), out subtotal);
                    total = total + subtotal;
                }
                CalcularTotales(total);


            }
            else
            {
                txtivaventa.Clear();
                txtnetoventa.Clear();
                txttotalventa.Clear();
            }
        }

        private void btventa_Click(object sender, EventArgs e)
        {
            string errores = "";
            bool estado = false;
            if (txtrutcliente.Text == "")
            {
                errores = errores + "debes ingresar el rut del cliente\n";
                estado = true;
            }

            if (txttotalventa.Text == "")
            {
                errores = errores + "ingresar un detalle de compra\n";
                estado = true;
            }
            if (txttotalventa.Text == "0")
            {
                errores = errores + "ingresar un detalle de compra\n";
                estado = true;
            }
            if (estado == true)
            {
                MessageBox.Show(errores);
            }
            else
            {
                rut_administrador = txtrutadministrador.Text;
                int.TryParse(txtventa.Text, out n_compra);
                int.TryParse(txtnetoventa.Text, out neto);
                int.TryParse(txtivaventa.Text, out iva);
                int.TryParse(txttotalventa.Text, out totales);
                for (int i = 0; i < grilladetalleventa.Rows.Count; i++)
                {
                    cantidad3 = int.Parse(grilladetalleventa.Rows[i].Cells[0].Value.ToString());
                    DataSet ds = venta.rescatarcodigoproducto(grilladetalleventa.Rows[i].Cells[1].Value.ToString());
                    int.TryParse(ds.Tables["Producto"].Rows[0][0].ToString(), out codigo3);
                    valorunitario3 = int.Parse(grilladetalleventa.Rows[i].Cells[2].Value.ToString());
                    subtotal3 = int.Parse(grilladetalleventa.Rows[i].Cells[3].Value.ToString());
                    DataSet ds7 = venta.informacion_productos(codigo3);
                    int.TryParse(ds7.Tables["Producto"].Rows[0][2].ToString(), out stockproducto);
                    suma = stockproducto - cantidad3;
                    venta.ingresar_detalleventa(n_compra, cantidad3, codigo3, valorunitario3, subtotal3);
                    venta.Modificarstockproducto(codigo3, suma);
                    venta.ingresar_Venta(int.Parse(txtventa.Text), txtfechaventa.Text,txtrutadministrador.Text,txtrutcliente.Text, neto, iva, totales);
                    MessageBox.Show("operacion ralizada con exito");
                    txtventa.Text = Convert.ToString(1 + int.Parse(venta.TraerValor("select isnull(max(N_Venta),0) from Venta")));
                    grilladetalleventa.Rows.RemoveAt(grilladetalleventa.CurrentRow.Index);
                    txtnetoventa.Clear();
                    txtivaventa.Clear();
                    txttotalventa.Clear();
                }
            }
        }

        private void btmenuprincipalventa_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();

        }

        private void btvolvermenuvendedorventa_Click(object sender, EventArgs e)
        {
            Menu_Vendedor Mvendedor = new Menu_Vendedor(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            Mvendedor.Show();
        }




    }
}
