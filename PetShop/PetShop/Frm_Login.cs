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
    public partial class Frm_Login : Form
    {
        /// <summary>
        /// Inicializa los componentes del Win Form
        /// </summary>
        public Frm_Login()
        {
            InitializeComponent();           
            
        }

        /// <summary>
        /// Ingresa a la app si los datos ingresados son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            ComercioPetShop.AgregarDictionaryUsuarios(usuarios);            
           
            foreach (KeyValuePair<string, string> item in usuarios)
            {                
                if (item.Key == txt_Usuario.Text && item.Value == txt_Password.Text)
                {
                    Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal(txt_Usuario.Text);
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    txt_Usuario.Text = string.Empty;
                    txt_Password.Text = string.Empty;
                    lbl_ErrorLogin.Text = "ACCESO DENEGADO\nUsuario y/o contraseña incorrectos";
                }
            }
        }
    }
}
