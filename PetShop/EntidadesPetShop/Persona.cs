using System;

namespace EntidadesPetShop
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string dni;
        private double cuil;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public double Cuil
        {
            get { return cuil; }
            set { cuil = value; }
        }
        #endregion

        #region Constructor
        protected Persona(string nombre, string apellido, string dni, double cuil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cuil = cuil;
        }

        #endregion
    }
}
