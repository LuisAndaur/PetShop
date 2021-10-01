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
    public partial class Frm_abmEmpleados : Frm_abmBase
    {
        private int indice = 0;
        List<Administrador> administradores = new List<Administrador>();
        List<Staff> staffer = new List<Staff>();
        public Frm_abmEmpleados() 
        {
            InitializeComponent();
            cmb_Enumerado.DataSource = Enum.GetValues(typeof(ERol));
            cmb_Enumerado.SelectedIndex = -1;
        }

        private void Frm_abmEmpleados_Load(object sender, EventArgs e)
        {
            administradores = ComercioPetShop.ListaAdministradores;
            staffer = ComercioPetShop.ListaStaff;
            ListarBase();
        }

        public override void ListarBase()
        {
            dgv_Lista.Rows.Clear();

            foreach (Administrador item in administradores)
            {
                int indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.Id;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Rol;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Nombre;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Apellido;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Dni;
                dgv_Lista.Rows[indice].Cells[5].Value = item.Cuil;
                dgv_Lista.Rows[indice].Cells[6].Value = item.Sueldo;
            }

            foreach (Staff item in staffer)
            {
                int indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.Id;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Rol;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Nombre;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Apellido;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Dni;
                dgv_Lista.Rows[indice].Cells[5].Value = item.Cuil;
                dgv_Lista.Rows[indice].Cells[6].Value = item.Sueldo;
            }
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_Id.Text = dgv_Lista.Rows[indice].Cells[0].Value.ToString();
                cmb_Enumerado.Text = dgv_Lista.Rows[indice].Cells[1].Value.ToString();
                txt_Nombre.Text = dgv_Lista.Rows[indice].Cells[2].Value.ToString();
                txt_Apellido.Text = dgv_Lista.Rows[indice].Cells[3].Value.ToString();
                txt_Dni.Text = dgv_Lista.Rows[indice].Cells[4].Value.ToString();
                txt_Cuil.Text = dgv_Lista.Rows[indice].Cells[5].Value.ToString();
                txt_Sueldo.Text = dgv_Lista.Rows[indice].Cells[6].Value.ToString();
            }
        }

        public override void txt_Editar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            Staff staff = new Staff();

            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                int.TryParse(txt_Id.Text, out int auxId);
                if ((ERol)cmb_Enumerado.SelectedItem == ERol.Administrador)
                {
                    
                    admin = ComercioPetShop.ObtenerAdmin(auxId);

                    if (admin != null)
                    {
                        ComercioPetShop.EditarAdmin(auxId, txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text);
                    }
                    else
                    {
                        ComercioPetShop.EditarStaff(auxId, txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text);
                        staff = ComercioPetShop.ObtenerStaff(auxId);
                        admin = (Administrador)staff;
                        administradores.Add(admin);
                        ComercioPetShop.EliminarStaff(auxId);
                    }
                }
                else
                {
                    staff = ComercioPetShop.ObtenerStaff(auxId);
                    if (staff != null)
                    {
                        ComercioPetShop.EditarStaff(auxId, txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text);
                    }
                    else
                    {
                        ComercioPetShop.EditarAdmin(auxId, txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text);
                        admin = ComercioPetShop.ObtenerAdmin(auxId);
                        staff = (Staff)admin;
                        staffer.Add(staff);
                        ComercioPetShop.EliminarAdmin(auxId);
                    }
                }
               
            }

            if (admin == null && staff == null)
            {
                MessageBox.Show("El empleado es nuevo. Agreguelo.");
            }
            ListarBase();
        }

        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                int.TryParse(txt_Id.Text, out int auxId);
                if (indice != -1)
                {
                    if ((ERol)cmb_Enumerado.SelectedItem == ERol.Administrador)
                    {
                        existe = ComercioPetShop.ExisteAdmin(auxId);
                        if (existe)
                        {
                            dgv_Lista.Rows.RemoveAt(indice);
                            ComercioPetShop.EliminarAdmin(auxId);
                        }
                    }
                    else
                    {
                        existe = ComercioPetShop.ExisteStaff(auxId);
                        if (existe)
                        {
                            dgv_Lista.Rows.RemoveAt(indice);
                            ComercioPetShop.EliminarStaff(auxId);                            
                        }
                    }                    
                }                
            }
            if (!existe)
            {
                MessageBox.Show("El empleado no existe en la lista, no se puede eliminar");
            }
            else
            {

            }
        }

        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;

            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                int.TryParse(txt_Id.Text, out int auxId);

                if ((ERol)cmb_Enumerado.SelectedItem == ERol.Administrador)
                {
                    existe = ComercioPetShop.ExisteAdmin(auxId);
                    if (!existe)
                    {
                        administradores.Add(Administrador.CrearAdmin(txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text));
                        MessageBox.Show("Nuevo empleado agregado");
                    }
                }
                else
                {
                    existe = ComercioPetShop.ExisteStaff(auxId);
                    if (!existe)
                    {
                        staffer.Add(Staff.CrearStaff(txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, txt_Cuil.Text, txt_Sueldo.Text));
                        MessageBox.Show("Nuevo empleado agregado");
                    }
                }
            }            

            if (existe)
            {
                MessageBox.Show("El empleado ya existe");
            }
            
            ListarBase();
        }

        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            base.Limpiar();
            cmb_Enumerado.SelectedIndex = -1;
            txt_Sueldo.Text = string.Empty;
        }

    }
}
