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
    public abstract partial class Frm_abmBase : Form
    {
        public Frm_abmBase()
        {
            InitializeComponent();
        }

        public abstract void ListarBase();

        public abstract void txt_Editar_Click(object sender, EventArgs e);

        public abstract void btn_Eliminar_Click(object sender, EventArgs e);

        public abstract void btn_Agregar_Click(object sender, EventArgs e);

        public abstract void btn_Limpiar_Click(object sender, EventArgs e);

        public abstract void Limpiar();

        public abstract void btn_Listar_Click(object sender, EventArgs e);

        private void txt_Cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
