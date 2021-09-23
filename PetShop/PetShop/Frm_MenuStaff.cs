using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Frm_MenuStaff : Frm_MenuBase
    {
        public Frm_MenuStaff()
        {
            InitializeComponent();
        }

        public Frm_MenuStaff(string nombreUsuario) : this()
        {
            this.lbl_TituloMenuPrincipal.Text = $"{this.lbl_TituloMenuPrincipal.Text}{nombreUsuario}";
        }
    }
}
