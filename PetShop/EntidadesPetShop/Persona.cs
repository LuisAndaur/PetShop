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
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }                
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    apellido = value;
                }                
            }
        }

        public string Dni
        {
            get { return dni; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    dni = value;
                }                 
            }
        }

        public double Cuil
        {
            get { return cuil; }
            set 
            {
                if (value > 0)
                {
                    cuil = value;
                }                 
            }
        }
        #endregion

        #region Constructor
        protected Persona(string nombre, string apellido, string dni, double cuil)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.cuil = cuil;
        }

        #endregion
    }
}
