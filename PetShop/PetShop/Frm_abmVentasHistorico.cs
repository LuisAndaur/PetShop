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
        List<Administrador> administradores = new List<Administrador>();
        List<Staff> staffer = new List<Staff>();
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productos = new List<Producto>();
        List<VentasHistoricas> ventasHistoricas = new List<VentasHistoricas>();

        public Frm_abmVentasHistorico()
        {
            InitializeComponent();
            //cmb_Empleados.DataSource = typeof(Administrador);
            cmb_Empleados.SelectedIndex = -1;
        }

        private void Frm_abmVentasHistorico_Load(object sender, EventArgs e)
        {
            clientes = ComercioPetShop.ListaClientes;
            productos = ComercioPetShop.ListaProductos;
            administradores = ComercioPetShop.ListaAdministradores;
            staffer = ComercioPetShop.ListaStaff;
            ventasHistoricas = ComercioPetShop.ListaVentasHistoricas;
            ListarBases();
        }

        public void ListarBases()
        {
            dgv_VentasHistorico.Rows.Clear();
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
    }
}
