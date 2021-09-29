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
        private ERol rol;
        private double sueldo;
        #endregion


        #region Propiedades
        public int Id
        {
            get { return id; }
        }

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

        public ERol Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        #endregion

        #region Constructor
        static Empleado()
        {
            ultimoIdGenerado = 99999;
        }

        public Empleado(string nombre, string apellido, string dni, double cuil) : base(nombre, apellido, dni, cuil)
        {

        }

        public Empleado(string nombre, string apellido, string dni, double cuil, string nombreUsuario, string pass, ERol rol, double sueldo) : this (nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.id = ultimoIdGenerado;
            this.Sueldo = sueldo;
            this.NombreUsuario = nombreUsuario;
            this.Pass = pass;
            this.Rol = rol;
        }
        #endregion

        public virtual double LiquidarSueldos(double sueldoActualizado)
        {            
            return this.Sueldo = sueldoActualizado;
        }

        public string GenerarNombreUsuario(string nombre, string apellido)
        {
            return $"{nombre[0]}{apellido}".ToLower();
        }

  
    }
}
