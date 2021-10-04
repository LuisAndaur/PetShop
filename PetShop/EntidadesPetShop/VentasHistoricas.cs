using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class VentasHistoricas
    {
        #region Atributos
        private int idVenta;
        private Empleado empleado;
        private Cliente cliente;
        private List<Producto> carrito;
        private List<decimal> cantidad;
        private static Dictionary<int, string> empleados;
        private string fecha;
        private double precioTotal;
        private static int ultimoIdGenerado;
        #endregion

        #region Propiedades
        public int IdVenta
        {
            get { return idVenta; }
        }

        public Empleado Empleado
        {
            get { return empleado; }
            set
            {
                if (value != null)
                {
                    empleado = value;
                }
            }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                if (value != null)
                {
                    cliente = value;
                }
            }
        }

        public List<Producto> Carrito
        {
            get { return carrito; }
            set
            {
                if (value != null)
                {
                    carrito = value;
                }
            }
        }

        public List<decimal> Cantidad
        {
            get { return cantidad; }
            set 
            {
                if (value != null)
                {
                    cantidad = value;
                }                 
            }
        }

        public static Dictionary<int, string> Empleados
        {
            get { return empleados; }
            set
            {
                if (value != null)
                {
                    empleados = value;
                }
            }
        }

        public string Fecha
        {
            get { return fecha; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fecha = value;
                }
            }
        }

        public double PrecioTotal
        {
            get { return precioTotal; }
            set
            {
                if (value > 0)
                {
                    precioTotal = value;
                }
            }
        }
        #endregion

        #region Constructor
        static VentasHistoricas()
        {
            ultimoIdGenerado = 0;
            empleados = new Dictionary<int, string>();
        }

        public VentasHistoricas(Empleado empleado, Cliente cliente, List<Producto> carrito, List<decimal> cantidad, string fecha, double precioTotal)
        {
            ultimoIdGenerado++;
            this.idVenta = ultimoIdGenerado;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Carrito = new List<Producto>();
            this.Cantidad = new List<decimal>();
            this.Fecha = fecha;
            this.PrecioTotal = precioTotal;
            ListaEmpleados(empleado);
        }
        #endregion

        #region Metodos

        public static List<VentasHistoricas> operator +(List<VentasHistoricas> ventasHistoricas, VentasHistoricas venta)
        {
            ventasHistoricas.Add(venta);
            return ventasHistoricas;
        }

        public static VentasHistoricas CargarVenta(Empleado empleado, Cliente cliente, List<Producto> carrito, List<decimal> cantidad, string fecha, double precioTotal)
        {
            if (empleado != null && cliente != null && carrito != null && cantidad != null && !string.IsNullOrEmpty(fecha) && precioTotal>0)
            {
                return new VentasHistoricas(empleado, cliente, carrito, cantidad, fecha, precioTotal);
            }
            return null;
        }



        public static void ListaEmpleados(Empleado empleado)
        {
            if (!empleados.ContainsKey(empleado.Id))
            {
                empleados.Add(empleado.Id, empleado.Nombre);
            }            
        }


        #endregion

    }
}
