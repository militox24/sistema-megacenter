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
    public partial class Mantenedor_Compra : Form
    {
        //string errores = "Usted tiene los siguientes errores\n";
        int codigo, cantidad, subtotal, valorunitario, totales, cantidad3, codigo3, valorunitario3, subtotal3, n_compra;
        string nombre, precio, rut_administrador;
       // bool estado = false;
        int neto, iva, suma, stockproducto;
       // bool bandera = false;
        //int resta = 0;
        Gestion_Compra Compra = new Gestion_Compra();
        Gestion_Proveedor proveedor = new Gestion_Proveedor();
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado;
        public Mantenedor_Compra(string nombre,string apellido,string rut,string url,string usuario)
        {
            InitializeComponent();
            txtrutadmin.Text = rut;
            nombreusuario = nombre;
            apellidousuario = apellido;
            urlimagen = url;
            rutusuario = rut;
            usuariologueado = usuario;
            DataSet ds = proveedor.rescatartodoslosproveedores();
            if (ds.Tables["Proveedor"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["Proveedor"].Rows.Count; i++)
                {
                    cbproveedor.Items.Add(ds.Tables["Proveedor"].Rows[i][0].ToString());
                }
            }
            txtfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Mantenedor_Compra_Load(object sender, EventArgs e)
        {
            txtcompra.Text = Convert.ToString(1 + int.Parse(Compra.TraerValor("select isnull(max(N_Compra),0) from compra")));
            inicializarCheckbox();
        }
        private void inicializarCheckbox()
        {
            for (int i = 0; i < grilladetallecompra.RowCount; i++)
            {
                grilladetallecompra[0, i].ReadOnly = true;
                grilladetallecompra[1, i].ReadOnly = true;
                grilladetallecompra[2, i].ReadOnly = true;
                grilladetallecompra[3, i].ReadOnly = true;
                grilladetallecompra[4, i].ReadOnly = true;
            }
        }
        private void CalcularTotales(int Total)
        {
            txttotal.Text = Total.ToString();
            txtneto.Text = Math.Round((Total / 1.19), 0).ToString();
            txtiva.Text = Math.Round((Total - (Total / 1.19)), 0).ToString();
        }
        private string isnull(string cadena)
        {
            if (cadena == "")
                cadena = "0";
            return cadena;
        }

        private void grilladetallecompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult dr;
                dr = MessageBox.Show("Esta seguro que desea ELIMINAR los datos", "Ventana de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            int totalfinal = 0;
                            int.TryParse(txttotal.Text, out totalfinal);
                            int.TryParse(grilladetallecompra.Rows[e.RowIndex].Cells[3].Value.ToString(), out subtotal);
                            totalfinal = totalfinal - subtotal;
                            CalcularTotales(totalfinal);
                            grilladetallecompra.Rows.RemoveAt(e.RowIndex);

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

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "" && txtcantidad.Text != "")
            {

                int.TryParse(txtcodigo.Text, out codigo);
                DataSet ds = Compra.informacion_productos(codigo);
                int existe = ds.Tables["Producto"].Rows.Count;
                if (existe != 0)
                {
                    nombre = ds.Tables["Producto"].Rows[0][0].ToString();
                    precio = ds.Tables["Producto"].Rows[0][1].ToString();
                    int.TryParse(precio, out valorunitario);
                    int.TryParse(txtcantidad.Text, out cantidad);
                    subtotal = cantidad * valorunitario;
                    grilladetallecompra.Rows.Add(cantidad, nombre, precio, subtotal);
                    txtcantidad.Clear();
                    txtcodigo.Clear();
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

        private void grilladetallecompra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int subtotal;
            int total = 0;
            if (grilladetallecompra.Rows.Count != 0)
            {
                for (int i = 0; i < grilladetallecompra.Rows.Count; i++)
                {

                    int.TryParse(grilladetallecompra.Rows[i].Cells[3].Value.ToString(), out subtotal);
                    total = total + subtotal;
                }
                CalcularTotales(total);


            }
            else
            {
                txtiva.Clear();
                txtneto.Clear();
                txttotal.Clear();
            }
        }

        private void btcompra_Click(object sender, EventArgs e)
        {
            string errores = "";
            bool estado = false;
            if (cbproveedor.Text == "")
            {
                errores = errores + "debes seleccionar el proveedor\n";
                estado = true;
            }

            if (txttotal.Text == "")
            {
                errores = errores + "ingresar un detalle de compra\n";
                estado = true;
            }
            if (txttotal.Text == "0")
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
                rut_administrador = txtrutadmin.Text;
                int.TryParse(txtcompra.Text, out n_compra);
                int.TryParse(txtneto.Text, out neto);
                int.TryParse(txtiva.Text, out iva);
                int.TryParse(txttotal.Text, out totales);
                for (int i = 0; i < grilladetallecompra.Rows.Count; i++)
                {
                    cantidad3 = int.Parse(grilladetallecompra.Rows[i].Cells[0].Value.ToString());
                    DataSet ds = Compra.rescatarcodigoproducto(grilladetallecompra.Rows[i].Cells[1].Value.ToString());
                    int.TryParse(ds.Tables["Producto"].Rows[0][0].ToString(), out codigo3);
                    valorunitario3 = int.Parse(grilladetallecompra.Rows[i].Cells[2].Value.ToString());
                    subtotal3 = int.Parse(grilladetallecompra.Rows[i].Cells[3].Value.ToString());
                    DataSet ds7 = Compra.informacion_productos(codigo3);
                    int.TryParse(ds7.Tables["Producto"].Rows[0][2].ToString(), out stockproducto);
                    suma = stockproducto + cantidad3;
                    Compra.ingresar_detallecompra(cantidad3, codigo3, valorunitario3, subtotal3,int.Parse(txtcompra.Text));
                    Compra.Modificarstockproducto(codigo3, suma);
                    Compra.ingresar_compra(int.Parse(txtcompra.Text),cbproveedor.Text, txtfecha.Text, neto, iva, totales, rut_administrador);
                    MessageBox.Show("operacion ralizada con exito","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtcompra.Text = Convert.ToString(1 + int.Parse(Compra.TraerValor("select isnull(max(N_Compra),0) from compra")));
                    cbproveedor.SelectedIndex = -1;
                    grilladetallecompra.Rows.RemoveAt(grilladetallecompra.CurrentRow.Index);
                    txtneto.Clear();
                    txtiva.Clear();
                    txttotal.Clear();
                }
            }
        }

        private void btvolvermenuprincipalcompra_Click(object sender, EventArgs e)
        {
            Menu_Principal principal = new Menu_Principal(nombreusuario,apellidousuario,urlimagen,rutusuario,usuariologueado);
            this.Hide();
            principal.Show();
        }




    }
}
