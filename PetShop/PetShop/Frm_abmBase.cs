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
    public partial class Frm_abmBase : Form
    {
        private DataTable tabla;
        List<Cliente> clientes = new List<Cliente>();
        public Frm_abmBase()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Load(object sender, EventArgs e)
        {
            ListarClientes();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //double.TryParse(txt_Billetera.Text, out double billetera);
            //Cliente newCliente = new Cliente(txt_Nombre.Text, txt_Apellido.Text, billetera);
          //  List<Cliente> clientes = new List<Cliente>();
           // ComercioPetShop.CargarListaClientes(clientes);
           // clientes.Add(newCliente);
            dgv_Tabla.DataSource = null;
           
            dgv_Tabla.DataSource = clientes;
            dgv_Tabla.Refresh();
        }

        public void ListarClientes()
        {
            //tabla = new DataTable();
            //tabla.Columns.Add("ID");
            //tabla.Columns.Add("Nombre");
            //tabla.Columns.Add("Apellido");
            //tabla.Columns.Add("Billetera");

            
          
            ComercioPetShop.CargarListaClientes(clientes);

            dgv_Tabla.DataSource = clientes;
        }
    }
}
