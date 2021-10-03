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
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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
        static Cliente()
        {
            ultimoIdGenerado = 999;
        }

        public Cliente(string nombre, string apellido, string dni, double cuil) : base(nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Saldo = SaldoRandom();
        }
        #endregion

        #region Metodos

        private double SaldoRandom()
        {
            Random random = new Random();
            return (double)random.Next(0, 5500);
        }

        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            clientes.Add(cliente);
            return clientes;
        }

        public static Cliente CrearCliente(string nombre, string apellido, string dni, string cuil)
        {
            if (nombre != null && apellido != null && dni != null && cuil != null)
            {
                double.TryParse(cuil, out double auxCuil);
                return new Cliente(nombre, apellido, dni, auxCuil);
            }
            return null;
        }

        #endregion




    }
}
