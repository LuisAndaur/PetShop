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
    public partial class Frm_MenuAdmin : Frm_MenuBase
    {
       
        public Frm_MenuAdmin()
        {
            InitializeComponent();
        }

        public Frm_MenuAdmin(string nombreUsuario) : this()
        {
            this.lbl_TituloMenuPrincipal.Text = $"{this.lbl_TituloMenuPrincipal.Text}{nombreUsuario}";
        }

    }
}
