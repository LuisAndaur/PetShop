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
                ListViewItem lista = new ListViewItem(item.IdProducto.ToString());
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Categoria.ToString());
                lista.SubItems.Add(item.Precio.ToString());
                lista.SubItems.Add(item.Descripcion);
                lista.SubItems.Add(item.Marca);
                lista.SubItems.Add(item.Stock.ToString());
                lvw_Lista.Items.Add(lista);
            }
        }
    }
}
