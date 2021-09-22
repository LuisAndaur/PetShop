using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Cliente : Persona
    {
        private static int ultimoIdGenerado;

        static Cliente()
        {
            ultimoIdGenerado = 1000;
        }

        public Cliente(string nombre, string apellido, double billetera) : base(nombre, apellido, billetera)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Billetera = billetera;
        }


        public override double DepositoBilletera()
        {
            throw new NotImplementedException();
        }

        public override double ExtraccionBilletera()
        {
            throw new NotImplementedException();
        }
    }
}
