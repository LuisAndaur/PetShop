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

        private void Frm_abmProductos_Load(object sender, EventArgs e)
        {
            productos = ComercioPetShop.ListaProductos;
            ListarBase();
        }

        public override void ListarBase()
        {
            dgv_Lista.Rows.Clear();
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
                nud_Stock.Text = dgv_Lista.Rows[indice].Cells[6].Value.ToString();
            }
        }

        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            base.Limpiar();
            cmb_Enumerado.SelectedIndex = -1;
            txt_Descripcion.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            txt_Marca.Text = string.Empty;
            nud_Stock.Value = 0;
        }
     
        public override void txt_Editar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerProducto(auxId) != null)
            {
                if (!string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Descripcion.Text) && !string.IsNullOrEmpty(txt_Precio.Text) && !string.IsNullOrEmpty(txt_Marca.Text)
                && nud_Stock.Value > 0 && cmb_Enumerado.SelectedIndex != -1 && !string.IsNullOrEmpty(txt_Id.Text))
                {
                    ComercioPetShop.EditarProducto(auxId, txt_Nombre.Text, txt_Descripcion.Text, nud_Stock.Value, txt_Precio.Text, txt_Marca.Text, cmb_Enumerado.Text);
                    MessageBox.Show("Nuevo producto editado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El producto es nuevo. Agreguelo.");
            }
            ListarBase();
        }

        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerProducto(auxId) != null)
            {
                if (!string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Descripcion.Text) && !string.IsNullOrEmpty(txt_Precio.Text) && !string.IsNullOrEmpty(txt_Marca.Text)
                && nud_Stock.Value > 0 && cmb_Enumerado.SelectedIndex != -1 && !string.IsNullOrEmpty(txt_Id.Text))
                {
                    ComercioPetShop.EliminarProducto(auxId);
                    MessageBox.Show("Producto eliminado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El producto no existe. No se puede eliminar.");
            }
            ListarBase();
        }

        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerProducto(auxId) == null)
            {
                if (!string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Descripcion.Text) && !string.IsNullOrEmpty(txt_Precio.Text) && !string.IsNullOrEmpty(txt_Marca.Text)
                && nud_Stock.Value > 0 && cmb_Enumerado.SelectedIndex != -1 && string.IsNullOrEmpty(txt_Id.Text))
                {
                    productos += Producto.CrearProducto(txt_Nombre.Text, txt_Precio.Text, nud_Stock.Value, txt_Descripcion.Text, txt_Marca.Text, cmb_Enumerado.Text);
                    MessageBox.Show("Nuevo producto agregado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El producto ya existe.");
            }
            ListarBase();
        }
    }
}
