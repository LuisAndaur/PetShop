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
            set { saldo = value; }
        }
        #endregion

        #region Constructor
        static Cliente()
        {
            ultimoIdGenerado = 999;
        }

        public Cliente(string nombre, string apellido, string dni, long cuil) : base(nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Saldo = SaldoRandom();
        }
        #endregion
        
        private double SaldoRandom()
        {
            Random random = new Random();
            return (double)random.Next(0,5500);
        }

    }
}
