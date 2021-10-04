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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos para mostrar en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_Load(object sender, EventArgs e)
        {
            lbl_ImporteCaja.Text = ComercioPetShop.MiCaja.ToString("N2");
        }
    }
}
