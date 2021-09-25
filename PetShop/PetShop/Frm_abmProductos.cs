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
    
    public partial class Frm_abmProductos : Frm_abmBase
    {
        List<Producto> productos = new List<Producto>();
        public Frm_abmProductos()
        {
            InitializeComponent();
            ListarBase();
        }

        public override void ListarBase()
        {
            ComercioPetShop.CargarProductos(productos);
            foreach (Producto item in productos)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.IdProducto;
                dataGridView1.Rows[indice].Cells[1].Value = item.Nombre;
                dataGridView1.Rows[indice].Cells[2].Value = item.Categoria;
                dataGridView1.Rows[indice].Cells[3].Value = item.Precio;
                dataGridView1.Rows[indice].Cells[4].Value = item.Descripcion;
                dataGridView1.Rows[indice].Cells[5].Value = item.Marca;
                dataGridView1.Rows[indice].Cells[6].Value = item.Stock;
            }
        }
    }
}
