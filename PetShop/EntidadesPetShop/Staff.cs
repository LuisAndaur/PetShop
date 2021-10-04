using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Staff : Empleado
    {
        #region Propiedades
        /// <summary>
        /// Propiedad rol staff
        /// </summary>
        public ERol Rol
        {
            get { return ERol.Staff; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor vacio por defecto
        /// </summary>
        public Staff() : base()
        {

        }
        /// <summary>
        /// Constructor completo de staff
        /// </summary>
        /// <param name="nombre">nombre del staff</param>
        /// <param name="apellido">apellido del staff</param>
        /// <param name="dni">dni del staff</param>
        /// <param name="cuil">cuil del staff</param>
        /// <param name="nombreUsuario">nombre de usuario del staff</param>
        /// <param name="pass">contraseña del staff</param>
        /// <param name="sueldo">sueldo del staff</param>
        public Staff(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, double sueldo) : base(nombre, apellido, dni, cuil, nombreUsuario, pass, sueldo)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Conversion explicita de un tipo Administrador a tipo staff
        /// </summary>
        /// <param name="empleado">Administrador a convertir</param>
        public static explicit operator Staff(Administrador empleado)
        {
            return new Staff(empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Cuil, empleado.NombreUsuario, empleado.Pass, empleado.Sueldo);
        }

        /// <summary>
        /// Crea un nuevo staff a partir de los datos pasados por parametro
        /// </summary>
        /// <param name="nombre">new nombre</param>
        /// <param name="apellido">new apellido</param>
        /// <param name="dni">new dni</param>
        /// <param name="cuil">new cuil</param>
        /// <param name="sueldo">new sueldo</param>
        /// <returns>new staff</returns>
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

        /// <summary>
        /// Aumenta sueldo del staff con un bono especial staff
        /// </summary>
        /// <param name="sueldoActualizado">porcentaje del aumento gral</param>
        public override void AumentarSueldos(double sueldoActualizado)
        {
            double bonoStaff = 0.05;
            sueldoActualizado += bonoStaff;
            base.AumentarSueldos(sueldoActualizado);
        }


        #endregion

    }
}
