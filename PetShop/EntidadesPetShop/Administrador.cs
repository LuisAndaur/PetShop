using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Administrador : Empleado
    {
        #region Atributos
        private double bono;
        #endregion

        #region Propiedades
        public double Bono
        {
            get { return bono; }
            set { bono = value; }
        }

        #endregion

        #region Constructor        
        public Administrador(int id, string nombre, string apellido, string dni, long cuil, Usuario usuario, double sueldo, double bono) : base(nombre, apellido, dni, cuil, usuario, sueldo)
        {
            this.Bono = bono;
        }

        #endregion
    }
}
