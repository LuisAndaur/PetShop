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
        public Frm_MenuBase()
        {
            InitializeComponent();

        }


        public Frm_MenuBase(Empleado empleado) : this ()
        {
            this.lbl_UsuarioActivo.Text = $"{this.lbl_UsuarioActivo.Text}{empleado.Nombre}";         
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            AbrirFormDentro(new Frm_Home());
            //pnl_Contenedor.BackColor = Color.Red;


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {            
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

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
            auxForm.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            AbrirFormDentro(new Frm_Home());
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Frm_abmClientes formClientes = new Frm_abmClientes();
            AbrirFormDentro(formClientes);
        }        

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Frm_abmProductos formProductos = new Frm_abmProductos();
            AbrirFormDentro(formProductos);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Frm_abmEmpleados formEmpleados = new Frm_abmEmpleados();
            AbrirFormDentro(formEmpleados);
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Frm_abmVentasHistorico formVentas = new Frm_abmVentasHistorico();
            AbrirFormDentro(formVentas);
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            Frm_Vender formVender = new Frm_Vender();
            AbrirFormDentro(formVender);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CambiarUsuario_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Hide();
        }

        private void Frm_MenuBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
  

    }
}
