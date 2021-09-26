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
        List<Empleado> empleados = new List<Empleado>();
        public Frm_abmEmpleados()
        {
            InitializeComponent();
            cmb_Rol.DataSource = Enum.GetValues(typeof(ERol));
        }

        public override void ListarBase()
        {
            foreach (Empleado item in empleados)
            {
                int indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.Id;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Apellido;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Dni;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Cuil;
                dgv_Lista.Rows[indice].Cells[5].Value = item.Sueldo;
            }
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_Id.Text = dgv_Lista.Rows[indice].Cells[0].Value.ToString();
                txt_Nombre.Text = dgv_Lista.Rows[indice].Cells[1].Value.ToString();
                txt_Apellido.Text = dgv_Lista.Rows[indice].Cells[2].Value.ToString();
                txt_Dni.Text = dgv_Lista.Rows[indice].Cells[3].Value.ToString();
                txt_Cuil.Text = dgv_Lista.Rows[indice].Cells[4].Value.ToString();
            }
        }

        public override void txt_Editar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            foreach (Empleado item in empleados)
            {
                if (item.Id == auxId)
                {
                    item.Nombre = txt_Nombre.Text;
                    item.Apellido = txt_Apellido.Text;
                    item.Dni = txt_Dni.Text;
                    item.Cuil = double.Parse(txt_Cuil.Text);
                    item.Usuario.NombreUsuario = $"{txt_Nombre.Text[0]}{txt_Apellido.Text}".ToUpper();
                    item.Usuario.Contraseña = txt_Dni.Text;
                    MessageBox.Show("Datos del emlpleado modificados");
                    existe = true;
                }
            }

            if (!existe)
            {
                MessageBox.Show("El cliente es nuevo. Agreguelo.");
            }
            ListarBase();
        }

        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            if (indice != -1)
            {
                foreach (Empleado item in empleados)
                {
                    if (item.Id == auxId)
                    {
                        dgv_Lista.Rows.RemoveAt(indice);
                        empleados.Remove(item);
                        existe = true;
                        MessageBox.Show("El cliente fue eliminado");
                        break;
                    }
                }
                if (!existe)
                {
                    MessageBox.Show("El cliente no existe en la lista, no se puede eliminar");
                }
            }
        }

        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int.TryParse(txt_Id.Text, out int auxId);
            foreach (Empleado item in empleados)
            {
                if (item.Id == auxId)
                {
                    MessageBox.Show("El empleado ya existe");
                    existe = true;
                }
            }

            if (!existe)
            {
                string nombreUsuario = $"{txt_Nombre.Text[0]}{txt_Apellido.Text}".ToUpper();
                Usuario usuario = new Usuario(nombreUsuario, txt_Dni.Text,(ERol)cmb_Rol.SelectedItem);
                                
                double.TryParse(txt_Cuil.Text, out double cuil);

                empleados.Add(new Empleado(txt_Nombre.Text, txt_Apellido.Text, txt_Dni.Text, cuil,usuario));
                MessageBox.Show("Nuevo empleado agregado agregado");
            }
            ListarBase();
        }

        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public override void Limpiar()
        {
            txt_Id.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Dni.Text = string.Empty;
            txt_Cuil.Text = string.Empty;
        }

        public override void btn_Listar_Click(object sender, EventArgs e)
        {
            ListarBase();
        }

        public void CopiarLista(List<Empleado> aux)
        {
            empleados = aux;
        }

    }
}
