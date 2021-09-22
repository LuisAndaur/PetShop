using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Administrador : Empleado
    {
        private static int ultimoIdGenerado;

        static Administrador()
        {
            ultimoIdGenerado = 500;
        }

        public Administrador(string nombre, string apellido, double billetera) : base(nombre, apellido, billetera)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Billetera = billetera;
        }
    }
}
