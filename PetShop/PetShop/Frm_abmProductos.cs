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
                txt_Stock.Text = dgv_Lista.Rows[indice].Cells[6].Value.ToString();
            }
        }

        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public override void Limpiar()
        {
            txt_Id.Text = string.Empty;
            cmb_Enumerado.SelectedIndex = -1;
            txt_Nombre.Text = string.Empty;
            txt_Descripcion.Text = string.Empty;
            txt_Stock.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            txt_Marca.Text = string.Empty;
        }

        public override void txt_Editar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            foreach (Producto item in productos)
            {
                if (item.IdProducto == auxId)
                {
                    item.Nombre = txt_Nombre.Text;
                    item.Descripcion = txt_Descripcion.Text;
                    item.Stock = int.Parse(txt_Stock.Text);
                    item.Precio = double.Parse(txt_Precio.Text);
                    item.Marca = txt_Marca.Text;
                    item.Categoria = Enum.Parse<ECategoria>(cmb_Enumerado.Text);
                    MessageBox.Show("Datos del producto modificados");
                    existe = true;
                }
            }

            if (!existe)
            {
                MessageBox.Show("El producto es nuevo. Agreguelo.");
            }
            ListarBase();
        }

        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            if (indice != -1)
            {
                foreach (Producto item in productos)
                {
                    if (item.IdProducto == auxId)
                    {
                        dgv_Lista.Rows.RemoveAt(indice);
                        productos.Remove(item);
                        existe = true;
                        MessageBox.Show("El producto fue eliminado");
                        break;
                    }
                }
                if (!existe)
                {
                    MessageBox.Show("El producto no existe en la lista, no se puede eliminar");
                }
            }
        }

        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            foreach (Producto item in productos)
            {
                if (item.IdProducto == auxId)
                {
                    MessageBox.Show("El producto ya existe");
                    existe = true;
                }
            }

            if (!existe)
            {
                double.TryParse(txt_Precio.Text, out double precio);
                int.TryParse(txt_Stock.Text, out int stock);

                productos.Add(new Producto(txt_Nombre.Text, precio, (ECategoria)cmb_Enumerado.SelectedItem, txt_Descripcion.Text, txt_Marca.Text, stock));
                MessageBox.Show("Nuevo producto agregado");
            }
            ListarBase();
        }

        public override void btn_Listar_Click(object sender, EventArgs e)
        {
            ListarBase();
        }

        public void CopiarLista(List<Producto> aux)
        {
            productos = aux;
        }
    }
}
