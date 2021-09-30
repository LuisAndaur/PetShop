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
    public partial class Frm_abmVender
    {
        List<VentasHistoricas> ventas = new List<VentasHistoricas>();
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productos = new List<Producto>();
        public Frm_abmVender()
        {
            InitializeComponent();
        }

    }
}
