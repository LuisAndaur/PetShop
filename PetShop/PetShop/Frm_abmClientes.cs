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
        List<Cliente> clientes = new List<Cliente>();

        public Frm_abmClientes()
        {
            InitializeComponent();
            ListarBase();            
        }

        public override void ListarBase()
        {
            ComercioPetShop.CargarListaClientes(clientes);
            
            foreach (Cliente item in clientes)
            {
                ListViewItem lista = new ListViewItem(item.Id.ToString());
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Dni);
                lista.SubItems.Add(item.Cuil.ToString());
                lista.SubItems.Add(item.Saldo.ToString());
                lvw_Lista.Items.Add(lista);

                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.Id;
                dataGridView1.Rows[indice].Cells[1].Value = item.Nombre;
                dataGridView1.Rows[indice].Cells[2].Value = item.Apellido;
                dataGridView1.Rows[indice].Cells[3].Value = item.Dni;
                dataGridView1.Rows[indice].Cells[4].Value = item.Cuil;
                dataGridView1.Rows[indice].Cells[5].Value = item.Saldo;


            }
        }


    }
}
