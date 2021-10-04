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
    public partial class Frm_MenuBase : Form
    {
        Empleado empleadoActivo = new Empleado();
        
        public Frm_MenuBase()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Sobrecarga de constructor que obtiene el empleado activo
        /// </summary>
        /// <param name="empleado">empleado registrado</param>
        public Frm_MenuBase(Empleado empleado) : this ()
        {
            this.lbl_UsuarioActivo.Text = $"{this.lbl_UsuarioActivo.Text}{empleado.Nombre}";
            empleadoActivo = empleado;
        }

        /// <summary>
        /// Carga el home y el tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Frm_Home formHome = new Frm_Home();
            AbrirFormDentro(formHome);
            formHome.BackColor = this.BackColor;
        }

        /// <summary>
        /// Realiza el conteo de tiempo y la fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {            
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Panel que sirve de contencion para otros forms
        /// </summary>
        /// <param name="Formhijo">form contenido</param>
        private void AbrirFormDentro(object Formhijo)
        {
            if (this.pnl_Contenedor.Controls.Count>0)
            {
                this.pnl_Contenedor.Controls.RemoveAt(0);
            }

            Form auxForm = Formhijo as Form;
            auxForm.TopLevel = false;
            auxForm.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(auxForm);
            this.pnl_Contenedor.Tag = auxForm;
            this.pnl_Contenedor.BackColor = Color.Transparent;
            auxForm.Show();
        }

        /// <summary>
        /// Crea y abre el form home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Frm_Home formHome = new Frm_Home();
            AbrirFormDentro(formHome);
            formHome.BackColor = this.BackColor;
        }

        /// <summary>
        /// Crea y abre el form clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Frm_abmClientes formClientes = new Frm_abmClientes();
            AbrirFormDentro(formClientes);
            formClientes.BackColor = this.BackColor;
        }

        /// <summary>
        /// Crea y abre el form productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Frm_abmProductos formProductos = new Frm_abmProductos();
            AbrirFormDentro(formProductos);
            formProductos.BackColor = this.BackColor;
        }

        /// <summary>
        /// Crea y abre el form empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Frm_abmEmpleados formEmpleados = new Frm_abmEmpleados();
            AbrirFormDentro(formEmpleados);
            formEmpleados.BackColor = this.BackColor;
        }

        /// <summary>
        /// Crea y abre el form ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Frm_abmVentasHistorico formVentas = new Frm_abmVentasHistorico();
            AbrirFormDentro(formVentas);
            formVentas.BackColor = this.BackColor;
        }

        /// <summary>
        /// Crea y abre el form vender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            Frm_Vender formVender = new Frm_Vender(empleadoActivo);
            AbrirFormDentro(formVender);
            formVender.BackColor = this.BackColor;
        }

        /// <summary>
        /// cierra la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        /// <summary>
        /// Retorna al login para cambiar de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CambiarUsuario_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Hide();
        }

        /// <summary>
        /// Antes de cerrar pregunta si deseamos cerrar de verdad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MenuBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
  

    }
}
