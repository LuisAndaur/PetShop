using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Ventas
    {
        #region Atributos
        private int idVenta;
        private Empleado empleado;
        private Cliente cliente;
        private Producto producto;
        private int cantidad;
        private double precioTotal;
        private static int ultimoIdGenerado;
        #endregion

        #region Propiedades
        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        #endregion

        #region Constructor
        static Ventas()
        {
            ultimoIdGenerado = 0;
        }

        public Ventas(Empleado empleado, Cliente cliente, Producto producto, int cantidad, double precioTotal)
        {
            ultimoIdGenerado++;
            this.IdVenta = ultimoIdGenerado;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
        }
        #endregion

        

    }
}
