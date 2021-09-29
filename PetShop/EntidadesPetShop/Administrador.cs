﻿using System;
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
            set 
            {
                if (value > 0)
                {
                    bono = value;
                }                 
            }
        }

        #endregion

        #region Constructor        
        public Administrador(int id, string nombre, string apellido, string dni, long cuil, string nombreUsuario, string pass, ERol rol, double sueldo, double bono) : base(nombre, apellido, dni, cuil, nombreUsuario, pass, rol, sueldo)
        {
            this.Bono = bono;
        }

        #endregion
    }
}
