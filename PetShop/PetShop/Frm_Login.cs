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
        List<Empleado> empleados = new List<Empleado>();
        
        
        /// <summary>
        /// Inicializa los componentes del Win Form
        /// </summary>
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            empleados = ComercioPetShop.ListaEmpleados;
        }

        /// <summary>
        /// Ingresa a la app si los datos ingresados son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            bool coincide = false;
            foreach (Empleado item in empleados)
            {                
                if (item.Usuario.NombreUsuario == txt_Usuario.Text && item.Usuario.Contraseña == txt_Password.Text)
                {
                    if (item.Usuario.Rol == ERol.Administrador)
                    {
                        Frm_MenuAdmin menuAdmin = new Frm_MenuAdmin(item.Nombre);
                        menuAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        Frm_MenuStaff menuStaff = new Frm_MenuStaff(item.Nombre);
                        menuStaff.Show();
                        this.Hide();
                    }                    
                    coincide = true;
                }                
            }
            if(!coincide)
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
            numero = random.Next(0, 2);

            txt_Usuario.Text = empleados[numero].Usuario.NombreUsuario;
            txt_Password.Text = empleados[numero].Usuario.Contraseña;
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            int numero;
            Random random = new Random();
            numero = random.Next(2, 5);

            txt_Usuario.Text = empleados[numero].Usuario.NombreUsuario;
            txt_Password.Text = empleados[numero].Usuario.Contraseña;
        }

        
    }
}
