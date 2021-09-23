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
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        static Cliente()
        {
            ultimoIdGenerado = 999;
        }

        public Cliente(string nombre, string apellido, string dni, string cuil) : base(nombre, apellido, dni, cuil)
        {
            ultimoIdGenerado++;
            this.Id = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

    }
}
