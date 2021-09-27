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
        private Usuario usuario;
        private double sueldo;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
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

        public Empleado(string nombre, string apellido, string dni, double cuil, Usuario usuario, double sueldo) : this (nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Sueldo = sueldo;
            this.Usuario = usuario;
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
