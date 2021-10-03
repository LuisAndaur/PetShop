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
        public List<Administrador> administradores = new List<Administrador>();
        public List<Staff> staff = new List<Staff>();
        
        
        /// <summary>
        /// Inicializa los componentes del Win Form
        /// </summary>
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            administradores = ComercioPetShop.ListaAdministradores;
            staff = ComercioPetShop.ListaStaff;
        }

        /// <summary>
        /// Ingresa a la app si los datos ingresados son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
           
            bool coincide = false;
            if (!string.IsNullOrEmpty(txt_Usuario.Text) || !string.IsNullOrEmpty(txt_Password.Text))
            {
                Administrador auxAdministrador = ComercioPetShop.LoguearAdministrador(txt_Usuario.Text, txt_Password.Text);
                Staff auxStaff = ComercioPetShop.LoguearStaff(txt_Usuario.Text, txt_Password.Text);
                if (auxAdministrador != null)
                {
                    Frm_MenuBase menuBase = new Frm_MenuBase(auxAdministrador);
                    menuBase.BackColor = Color.LightCoral;
                    menuBase.Show();                    
                    this.Hide();
                    coincide = true;
                }
                else
                {
                    Frm_MenuBase menuBase = new Frm_MenuBase(auxStaff);
                    menuBase.BackColor = Color.Lavender;
                    menuBase.Show();                    
                    menuBase.btn_Empleados.Visible = false;
                    menuBase.btn_Ventas.Visible = false;
                    this.Hide();
                    coincide = true;
                }
            }            

            if (!coincide)
            {
                txt_Usuario.Text = string.Empty;
                txt_Password.Text = string.Empty;
                lbl_ErrorLogin.Text = "ACCESO DENEGADO\nUsuario y/o contraseña incorrectos";
            }
        }

        private void btn_Administrador_Click(object sender, EventArgs e)
        {
            int numero;
            Random random = new Random();
            numero = random.Next(0, administradores.Count);

            txt_Usuario.Text = administradores[numero].NombreUsuario;
            txt_Password.Text = administradores[numero].Pass;
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            int numero;
            Random random = new Random();
            numero = random.Next(0, staff.Count);

            txt_Usuario.Text = staff[numero].NombreUsuario;
            txt_Password.Text = staff[numero].Pass;
        }

        
    }
}
