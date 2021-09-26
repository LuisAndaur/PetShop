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
    public partial class Frm_abmVentas : Frm_abmBase
    {
        List<Ventas> ventas = new List<Ventas>();
        public Frm_abmVentas()
        {
            InitializeComponent();
        }

        public override void ListarBase()
        {
            //ComercioPetShop.CargarListaClientes(clientes);
            //ComercioPetShop.CargarUsuarios(usuarios);
            //ComercioPetShop.CargarListaEmpleados(empleados, usuarios);
            //ComercioPetShop.CargarProductos(productos);
            //ComercioPetShop.CargarVentas(ventas, empleados, clientes, productos);

            foreach (Ventas item in ventas)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.IdVenta;
                dataGridView1.Rows[indice].Cells[1].Value = item.Empleado.Nombre;
                dataGridView1.Rows[indice].Cells[2].Value = item.Cliente.Nombre;
                dataGridView1.Rows[indice].Cells[3].Value = item.Producto.Nombre;
                dataGridView1.Rows[indice].Cells[4].Value = item.Cantidad;
                dataGridView1.Rows[indice].Cells[5].Value = item.PrecioTotal;
            }
        }
        public void CopiarLista(List<Ventas> aux)
        {
            ventas = aux;
        }
    }
}
