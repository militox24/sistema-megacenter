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
    public partial class Mantenedor_Historial_Multas : Form
    {
        Gestion_Multa multa = new Gestion_Multa();
        public Mantenedor_Historial_Multas(string nombre,string apellido,string url,string rut,string correo)
        {
            InitializeComponent();
            label2.Text = nombre + " " + apellido;
            GrillaHistorial.DataSource = multa.buscar_multa(rut);
            GrillaHistorial.DataMember = "Multa";
            GrillaHistorial.Columns["Rut_Vendedor"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaHistorial.Columns["Motivo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaHistorial.Columns["Detalle_Multa"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaHistorial.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaHistorial.Columns["Fecha"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GrillaHistorial.Columns["Rut_Vendedor"].Width = 150;
            GrillaHistorial.Columns["Motivo"].Width = 200;
            GrillaHistorial.Columns["Detalle_Multa"].Width = 300;
            GrillaHistorial.Columns["Monto"].Width = 100;
            GrillaHistorial.Columns["Fecha"].Width = 100;
            for (int i = 0; i < GrillaHistorial.RowCount; i++)
            {
                GrillaHistorial[0, i].ReadOnly = true;
                GrillaHistorial[1, i].ReadOnly = true;
                GrillaHistorial[2, i].ReadOnly = true;
                GrillaHistorial[3, i].ReadOnly = true;
                GrillaHistorial[4, i].ReadOnly = true;
            }
            
        }
    }
}
