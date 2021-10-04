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
    public partial class Frm_Home : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<VentasHistoricas> ventasHistoricas = new List<VentasHistoricas>();
        List<Administrador> admin = new List<Administrador>();
        List<Staff> staff = new List<Staff>();

        public Frm_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos para mostrar en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_Load(object sender, EventArgs e)
        {
            clientes = ComercioPetShop.ListaClientes;
            admin = ComercioPetShop.ListaAdministradores;
            staff = ComercioPetShop.ListaStaff;
            ventasHistoricas = ComercioPetShop.ListaVentasHistoricas;

            lbl_ImporteCaja.Text = ComercioPetShop.MiCaja.ToString("N2");
            lbl_CantClientes.Text = clientes.Count.ToString();
            lbl_CantEmpleados.Text = (admin.Count + staff.Count).ToString();
            lbl_CantVentas.Text = ventasHistoricas.Count.ToString();
        }

    }
}
