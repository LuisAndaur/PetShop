using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Staff : Empleado
    {
        public ERol Rol
        {
            get { return ERol.Staff; }
        }

        public Staff() : base()
        {

        }

        public Staff(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, double sueldo) : base(nombre, apellido, dni, cuil, nombreUsuario, pass, sueldo)
        {

        }

        public static explicit operator Staff(Administrador empleado)
        {
            return new Staff(empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Cuil, empleado.NombreUsuario, empleado.Pass, empleado.Sueldo);
        }

        public static Staff CrearStaff(string nombre, string apellido, string dni, string cuil, string sueldo)
        {
            string nombreUsuario;

            if (nombre != null && apellido != null && dni != null && cuil != null && sueldo != null)
            {
                double.TryParse(cuil, out double auxCuil);
                double.TryParse(sueldo, out double auxSueldo);
                nombreUsuario = GenerarNombreUsuario(nombre, apellido);

                return new Staff(nombre, apellido, dni, auxCuil, nombreUsuario, dni, auxSueldo);
            }
            return null;
        }

        public override double AumentarSueldos(double sueldoActualizado)
        {
            double bonoStaff = 0.3;
            return base.AumentarSueldos(sueldoActualizado) * bonoStaff;
        }
    }
}
