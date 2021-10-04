using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Empleado : Persona
    {
        #region Atributos
        private static int ultimoIdGenerado;
        private int id;
        private string nombreUsuario;
        private string pass;        
        private double sueldo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad readonly de id
        /// </summary>
        public int Id
        {
            get { return id; }
        }
        /// <summary>
        /// Propiedad sueldo del empleado
        /// </summary>
        public double Sueldo
        {
            get { return sueldo; }
            set 
            {
                if (value > 0)
                {
                    sueldo = value;
                }                
            }
        }
        /// <summary>
        /// Propiedad nombbre usuario 
        /// </summary>
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombreUsuario = value;
                }                 
            }
        }
        /// <summary>
        /// Propiedad contraseña
        /// </summary>
        public string Pass
        {
            get { return pass; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pass = value;
                }
            }
        }


        #endregion

        #region Constructor
        /// <summary>
        /// Constructor empleado static inicializa id
        /// </summary>
        static Empleado()
        {
            ultimoIdGenerado = 99999;
        }

        /// <summary>
        /// Constructor empleado vacio por defecto
        /// </summary>
        public Empleado() : base()
        {

        }

        /// <summary>
        /// Constructor que sobrecarga con base
        /// </summary>
        /// <param name="nombre">nombre empleado</param>
        /// <param name="apellido">apellido empleado</param>
        /// <param name="dni">dni empleado</param>
        /// <param name="cuil">cuil empleado</param>
        public Empleado(string nombre, string apellido, string dni, double cuil) : base(nombre, apellido, dni, cuil)
        {

        }

        /// <summary>
        /// Comstructor que carga id sueldo nombre de usuario y contraseña
        /// </summary>
        /// <param name="nombre">nombre empleado</param>
        /// <param name="apellido">apellido empleado</param>
        /// <param name="dni">dni empleado</param>
        /// <param name="cuil">cuil empleado</param>
        /// <param name="nombreUsuario">nombre de usuario empleado</param>
        /// <param name="pass">contraseña empleado</param>
        /// <param name="sueldo">sueldo empleado</param>
        public Empleado(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, double sueldo) : this (nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.id = ultimoIdGenerado;
            this.Sueldo = sueldo;
            this.NombreUsuario = nombreUsuario;
            this.Pass = pass;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Aumenta los sueldod e los empleados
        /// </summary>
        /// <param name="sueldoActualizado">porcentaje de aumento</param>
        public virtual void AumentarSueldos(double sueldoActualizado)
        {
            this.Sueldo *= sueldoActualizado;
            this.Sueldo -= Descontar();
        }

        /// <summary>
        /// Genera el nombre de usuario con los datos pasados por parametro
        /// </summary>
        /// <param name="nombre">nombre mpleado</param>
        /// <param name="apellido">apelllido empleado</param>
        /// <returns>el nombre de usuario nuevo</returns>
        public static string GenerarNombreUsuario(string nombre, string apellido)
        {
            return $"{nombre[0]}{apellido}".ToLower();
        }

        /// <summary>
        /// Descuenta un porcentaje de ganancias del sueldo
        /// </summary>
        /// <returns>el sueldo actualizado</returns>
        public override double Descontar()
        {
            double ganancias = 0.35;
            return Sueldo * ganancias;
        }

        #endregion
    }
}
