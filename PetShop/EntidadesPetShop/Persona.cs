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
        /// <summary>
        /// Propiedad nombre persona
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }                
            }
        }

        /// <summary>
        /// Propiedad apellido persona
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.apellido = value;
                }                
            }
        }

        /// <summary>
        /// Propiedad dni persona
        /// </summary>
        public string Dni
        {
            get { return dni; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.dni = value;
                }                 
            }
        }

        /// <summary>
        /// Propiedad cuil persona
        /// </summary>
        public double Cuil
        {
            get { return cuil; }
            set 
            {
                if (value > 0)
                {
                    this.cuil = value;
                }                 
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor vacio por defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor completo de persona
        /// </summary>
        /// <param name="nombre">nombre persona</param>
        /// <param name="apellido">apellido persona</param>
        /// <param name="dni">dni persona</param>
        /// <param name="cuil">cuil persona</param>
        public Persona(string nombre, string apellido, string dni, double cuil) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.cuil = cuil;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo abstracto de la clase abstracta persona
        /// </summary>
        /// <returns>un valor tipo double</returns>
        public abstract double Descontar();

        #endregion

    }
}
