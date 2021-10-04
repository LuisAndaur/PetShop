using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Cliente : Persona
    {
        #region Atributos
        private static int ultimoIdGenerado;
        private int id;
        private double saldo;
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad id readonly
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// propiedad saldo del cliente
        /// </summary>
        public double Saldo
        {
            get { return saldo; }
            set 
            {
                if (value > -1)
                {
                    saldo = value;
                }                 
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor static cliente inicializa id
        /// </summary>
        static Cliente()
        {
            ultimoIdGenerado = 999;
        }

        /// <summary>
        /// Constructor completo cliente
        /// </summary>
        /// <param name="nombre">nombre cliente</param>
        /// <param name="apellido">apellido cliente</param>
        /// <param name="dni">dni cliente</param>
        /// <param name="cuil">cuil cliente</param>
        public Cliente(string nombre, string apellido, string dni, double cuil) : base(nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Saldo = SaldoRandom();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Genera el saldo del cliente de forma random
        /// </summary>
        /// <returns>el saldo del cliente</returns>
        private double SaldoRandom()
        {
            Random random = new Random();
            return (double)random.Next(0, 60000);
        }

        /// <summary>
        /// Sobrecarga del operador +, añade un cleinte a la lista de clientes
        /// </summary>
        /// <param name="clientes">lista de clientes</param>
        /// <param name="cliente">un cliente</param>
        /// <returns>la lista actualizada</returns>
        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            clientes.Add(cliente);
            return clientes;
        }

        /// <summary>
        /// Crea un cliente a partir de los datos pasados por parametros
        /// </summary>
        /// <param name="nombre">nombre new cliente</param>
        /// <param name="apellido">apellido new cliente</param>
        /// <param name="dni">dni new cliente</param>
        /// <param name="cuil">cuil new cliente</param>
        /// <returns>el new cliente</returns>
        public static Cliente CrearCliente(string nombre, string apellido, string dni, string cuil)
        {
            if (nombre != null && apellido != null && dni != null && cuil != null)
            {
                double.TryParse(cuil, out double auxCuil);
                return new Cliente(nombre, apellido, dni, auxCuil);
            }
            return null;
        }

        /// <summary>
        /// Descuenta una cuota del cliente en el pet shop
        /// </summary>
        /// <returns>el saldo con la cuota descontada</returns>
        public override double Descontar()
        {
            double cuotaPet = 250;
            return Saldo -= cuotaPet;
        }

        #endregion

    }
}
