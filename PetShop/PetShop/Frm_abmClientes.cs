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
    public partial class Frm_abmClientes : Frm_abmBase
    {
        private int indice = 0;
        List<Cliente> clientes = new List<Cliente>();
        
        public Frm_abmClientes()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Carga la lista de clientes y los lista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_abmClientes_Load(object sender, EventArgs e)
        {
            clientes = ComercioPetShop.ListaClientes;
            ListarBase();
        }

        /// <summary>
        /// Lista la base de clientes
        /// </summary>
        public override void ListarBase()
        {
            dgv_Lista.Rows.Clear();
            foreach (Cliente item in clientes)
            {
                indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.Id;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Apellido;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Dni;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Cuil;
                dgv_Lista.Rows[indice].Cells[5].Value = item.Saldo;
            }
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_Id.Text = dgv_Lista.Rows[indice].Cells[0].Value.ToString();
                txt_Nombre.Text = dgv_Lista.Rows[indice].Cells[1].Value.ToString();
                txt_Apellido.Text = dgv_Lista.Rows[indice].Cells[2].Value.ToString();
                txt_Dni.Text = dgv_Lista.Rows[indice].Cells[3].Value.ToString();
                txt_Cuil.Text = dgv_Lista.Rows[indice].Cells[4].Value.ToString();
            }
        }

        /// <summary>
        /// Edita los datos del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void txt_Editar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerCliente(auxId) != null)
            {
                if (!string.IsNullOrEmpty(txt_Id.Text) && !string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Dni.Text) && !string.IsNullOrEmpty(txt_Cuil.Text))
                {
                    ComercioPetShop.EditarCliente(auxId, txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text);
                    MessageBox.Show("Nuevo cliente editado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El cliente es nuevo. Agreguelo.");
            }
            ListarBase();
        }

        /// <summary>
        /// Elimina el cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerCliente(auxId) != null)
            {
                if (!string.IsNullOrEmpty(txt_Id.Text) && !string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Dni.Text) && !string.IsNullOrEmpty(txt_Cuil.Text))
                {
                    ComercioPetShop.EliminarCliente(auxId);
                    MessageBox.Show("Cliente eliminado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El cliente no existe. No se puede eliminar.");
            }
            ListarBase();
        }

        /// <summary>
        /// Agrega un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Id.Text, out int auxId);
            if (ComercioPetShop.ObtenerProducto(auxId) == null)
            {
                if (string.IsNullOrEmpty(txt_Id.Text) && !string.IsNullOrEmpty(txt_Nombre.Text) && !string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Dni.Text) && !string.IsNullOrEmpty(txt_Cuil.Text))
                {
                    clientes += Cliente.CrearCliente(txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text);
                    MessageBox.Show("Nuevo cliente agregado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("El cliente ya existe.");
            }
            ListarBase();
        }

        /// <summary>
        /// Limpia todos los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            base.Limpiar();
        } 
    }
}
