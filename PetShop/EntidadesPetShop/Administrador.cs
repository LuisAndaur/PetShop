using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Administrador : Empleado
    {
        #region Propiedades
        /// <summary>
        /// Propiedad del rol administrador
        /// </summary>
        public ERol Rol
        {
            get { return ERol.Administrador;  }
        }

        #endregion

        #region Constructor     

        /// <summary>
        /// Constructor vacio por defecto
        /// </summary>
        public Administrador() : base()
        {

        }

        /// <summary>
        /// Constructor completo de administrador
        /// </summary>
        /// <param name="nombre">nombre del administrador</param>
        /// <param name="apellido">apellido del administrador</param>
        /// <param name="dni">dni del administrador</param>
        /// <param name="cuil">cuil del administrador</param>
        /// <param name="nombreUsuario">nombre de usuario del administrador</param>
        /// <param name="pass">contraseña del administrador</param>
        /// <param name="sueldo">sueldo del administrador</param>
        public Administrador(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, double sueldo) : base(nombre, apellido, dni, cuil, nombreUsuario, pass, sueldo)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Conversion explicita de un empleado staff a un empleado administrador
        /// </summary>
        /// <param name="empleado">empleado tipo staff</param>
        public static explicit operator Administrador(Staff empleado)
        {

            return new Administrador(empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Cuil, empleado.NombreUsuario, empleado.Pass, empleado.Sueldo);
        }

        /// <summary>
        /// Crea un Administrador a partir de los datos pasados por parametro
        /// </summary>
        /// <param name="nombre">nombre del new admin</param>
        /// <param name="apellido">apellido del new admin</param>
        /// <param name="dni">dni del new admin</param>
        /// <param name="cuil">cuil del new admin</param>
        /// <param name="sueldo">sueldo del new admin</param>
        /// <returns></returns>
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

        /// <summary>
        /// Aumenta el sueldo adicionando un bono de administrador
        /// </summary>
        /// <param name="sueldoActualizado">porcentaje de actualizacion de sueldo</param>
        public override void AumentarSueldos(double sueldoActualizado)
        {
            double bonoAdmin = 0.15;
            sueldoActualizado += bonoAdmin;
            base.AumentarSueldos(sueldoActualizado);
        }

        #endregion

    }
}
