using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Administrador : Empleado
    {
        #region Atributos

        #endregion

        #region Propiedades
        public ERol Rol
        {
            get { return ERol.Administrador;  }
        }

        #endregion

        #region Constructor     

        public Administrador() : base()
        {

        }

        public Administrador(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, double sueldo) : base(nombre, apellido, dni, cuil, nombreUsuario, pass, sueldo)
        {

        }

        #endregion

        public static explicit operator Administrador(Staff empleado)
        {
           
            return new Administrador(empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Cuil, empleado.NombreUsuario, empleado.Pass, empleado.Sueldo);
        }

        public static Administrador CrearAdmin(string nombre, string apellido, string dni, string cuil, string sueldo)
        {
            string nombreUsuario;

            if (nombre != null && apellido != null && dni != null && cuil != null && sueldo != null)
            {
                double.TryParse(cuil, out double auxCuil);
                double.TryParse(sueldo, out double auxSueldo);
                nombreUsuario = GenerarNombreUsuario(nombre, apellido);
                
                return new Administrador(nombre, apellido, dni, auxCuil, nombreUsuario, dni, auxSueldo);
            }
            return null;
        }

        public override void AumentarSueldos(double sueldoActualizado)
        {
            double bonoAdmin = 1.3;
            sueldoActualizado += bonoAdmin;
            base.AumentarSueldos(sueldoActualizado);
        }

        
    }
}
