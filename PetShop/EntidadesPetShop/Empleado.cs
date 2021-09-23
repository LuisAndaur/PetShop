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

        public Empleado(string nombre, string apellido, string dni, string cuil, Usuario usuario, double sueldo) : base(nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sueldo = sueldo;
            this.Dni = dni;
            this.Cuil = cuil;
            this.Usuario = usuario;
        }

        #endregion
    }
}
