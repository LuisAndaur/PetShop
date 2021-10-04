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
    public  partial class Frm_abmBase : Form
    {
        public Frm_abmBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lista la base para mostrar
        /// </summary>
        public virtual void ListarBase() { }

        public virtual void txt_Editar_Click(object sender, EventArgs e) { }

        public virtual void btn_Eliminar_Click(object sender, EventArgs e) { }

        public virtual void btn_Agregar_Click(object sender, EventArgs e) { }

        public virtual void btn_Limpiar_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Resetea los campos
        /// </summary>
        public virtual void Limpiar()
        {
            txt_Id.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Dni.Text = string.Empty;
            txt_Cuil.Text = string.Empty;
        }

        /// <summary>
        /// Permite ingresar solo letras
        /// </summary>
        /// <param name="e"></param>
        private void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar solo numeros
        /// </summary>
        /// <param name="e"></param>
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }               

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
