using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPetShop;

namespace PetShop
{
    public partial class Frm_abmVentasHistorico : Form
    {
        private int indice = 0;
        private string fecha = string.Empty;
        List<VentasHistoricas> ventasHistoricas = new List<VentasHistoricas>();

        public Frm_abmVentasHistorico()
        {
            InitializeComponent();            
            cmb_Empleados.SelectedIndex = -1;
        }

        /// <summary>
        /// Carga la lista de ventas, los empleados que vendieron y los lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_abmVentasHistorico_Load(object sender, EventArgs e)
        {
            ventasHistoricas = ComercioPetShop.ListaVentasHistoricas;
            foreach (KeyValuePair<int, string> item in VentasHistoricas.Empleados)
            {
                cmb_Empleados.Items.Add(item.Value);
            }
            ListarBases();
        }

        /// <summary>
        /// Lista la base de ventas
        /// </summary>
        public void ListarBases()
        {
            dgv_VentasHistorico.Rows.Clear();
            
            foreach (VentasHistoricas item in ventasHistoricas)
            {
                indice = dgv_VentasHistorico.Rows.Add();
                dgv_VentasHistorico.Rows[indice].Cells[0].Value = item.IdVenta;
                dgv_VentasHistorico.Rows[indice].Cells[1].Value = item.Fecha;
                dgv_VentasHistorico.Rows[indice].Cells[2].Value = item.Empleado.Nombre;
                dgv_VentasHistorico.Rows[indice].Cells[3].Value = item.Cliente.Nombre;
                dgv_VentasHistorico.Rows[indice].Cells[4].Value = item.Cliente.Apellido;
                dgv_VentasHistorico.Rows[indice].Cells[5].Value = item.Cliente.Dni;
                dgv_VentasHistorico.Rows[indice].Cells[6].Value = item.PrecioTotal.ToString("N2");
            }            
        }

        /// <summary>
        /// Filtra de ventas que hizo el vendedor seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleados.SelectedIndex != -1)
            {
                dgv_VentasHistorico.Rows.Clear();
                foreach (VentasHistoricas item in ventasHistoricas)
                {
                    if (item.Empleado.Nombre == cmb_Empleados.Text)
                    {
                        indice = dgv_VentasHistorico.Rows.Add();
                        dgv_VentasHistorico.Rows[indice].Cells[0].Value = item.IdVenta;
                        dgv_VentasHistorico.Rows[indice].Cells[1].Value = item.Fecha;
                        dgv_VentasHistorico.Rows[indice].Cells[2].Value = item.Empleado.Nombre;
                        dgv_VentasHistorico.Rows[indice].Cells[3].Value = item.Cliente.Nombre;
                        dgv_VentasHistorico.Rows[indice].Cells[4].Value = item.Cliente.Apellido;
                        dgv_VentasHistorico.Rows[indice].Cells[5].Value = item.Cliente.Dni;
                        dgv_VentasHistorico.Rows[indice].Cells[6].Value = item.PrecioTotal.ToString("N2");
                    }
                }
            }            
        }

        /// <summary>
        /// Refresca y muestra todas las ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Historico_Click(object sender, EventArgs e)
        {
            cmb_Empleados.SelectedIndex = -1;
            ListarBases();
        }        
    }
}
