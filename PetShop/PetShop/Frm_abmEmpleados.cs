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
        List<Empleado> empleados = new List<Empleado>();
        List<Usuario> usuarios = new List<Usuario>();
        public Frm_abmEmpleados()
        {
            InitializeComponent();
            ListarBase();
        }

        public override void ListarBase()
        {
            ComercioPetShop.CargarUsuarios(usuarios);
            ComercioPetShop.CargarListaEmpleados(empleados, usuarios);

            foreach (Empleado item in empleados)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = item.Id;
                dataGridView1.Rows[indice].Cells[1].Value = item.Nombre;
                dataGridView1.Rows[indice].Cells[2].Value = item.Apellido;
                dataGridView1.Rows[indice].Cells[3].Value = item.Dni;
                dataGridView1.Rows[indice].Cells[4].Value = item.Cuil;
                dataGridView1.Rows[indice].Cells[5].Value = item.Sueldo;
            }
        }
    }
}
