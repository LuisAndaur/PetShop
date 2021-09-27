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
        private int indice = 0;
        List<Producto> productos = new List<Producto>();
        public Frm_abmProductos()
        {
            InitializeComponent();
            cmb_Enumerado.DataSource = Enum.GetValues(typeof(ECategoria));
            cmb_Enumerado.SelectedIndex = -1;
        }

        public override void ListarBase()
        {
            foreach (Producto item in productos)
            {
                int indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.IdProducto;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Categoria;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Precio;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Descripcion;
                dgv_Lista.Rows[indice].Cells[5].Value = item.Marca;
                dgv_Lista.Rows[indice].Cells[6].Value = item.Stock;
            }
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_Id.Text = dgv_Lista.Rows[indice].Cells[0].Value.ToString();
                txt_Nombre.Text = dgv_Lista.Rows[indice].Cells[1].Value.ToString();
                cmb_Enumerado.Text = dgv_Lista.Rows[indice].Cells[2].Value.ToString();
                txt_Precio.Text = dgv_Lista.Rows[indice].Cells[3].Value.ToString();
                txt_Descripcion.Text = dgv_Lista.Rows[indice].Cells[4].Value.ToString();
                txt_Marca.Text = dgv_Lista.Rows[indice].Cells[5].Value.ToString();
                txt_Stock.Text = dgv_Lista.Rows[indice].Cells[6].Value.ToString();
            }
        }

        public void CopiarLista(List<Producto> aux)
        {
            productos = aux;
        }

        private void btn_Listar_Click_1(object sender, EventArgs e)
        {
            ListarBase();
        }
    }
}
