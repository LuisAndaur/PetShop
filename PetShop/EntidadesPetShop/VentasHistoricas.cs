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

        /// <summary>
        /// Propiedad readonly id
        /// </summary>
        public int IdVenta
        {
            get { return idVenta; }
        }

        /// <summary>
        /// empleado que vendió
        /// </summary>
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

        /// <summary>
        /// cliente que compro
        /// </summary>
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

        /// <summary>
        /// Carrito de productos
        /// </summary>
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

        /// <summary>
        /// Lista de cantidad
        /// </summary>
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

        /// <summary>
        /// Dictionary de empelados que vendieron
        /// </summary>
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

        /// <summary>
        /// Fecha de venta
        /// </summary>
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

        /// <summary>
        /// Precio total de la venta
        /// </summary>
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
        /// <summary>
        /// Constructor static que inicializa id y empleados que vendieron
        /// </summary>
        static VentasHistoricas()
        {
            ultimoIdGenerado = 0;
            empleados = new Dictionary<int, string>();
        }

        /// <summary>
        /// Constructor completo de ventas
        /// </summary>
        /// <param name="empleado">vendedor</param>
        /// <param name="cliente">comprador</param>
        /// <param name="carrito">lista de productos</param>
        /// <param name="cantidad">lista de cantidades</param>
        /// <param name="fecha">fecha de venta</param>
        /// <param name="precioTotal">precio de la venta</param>
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

        /// <summary>
        /// Sobrecarga del operador +, añade una venta a la lista de ventas
        /// </summary>
        /// <param name="ventasHistoricas">lista de ventas</param>
        /// <param name="venta">venta actual</param>
        /// <returns>lista actualizada</returns>
        public static List<VentasHistoricas> operator +(List<VentasHistoricas> ventasHistoricas, VentasHistoricas venta)
        {
            ventasHistoricas.Add(venta);
            return ventasHistoricas;
        }

        /// <summary>
        /// Carga una nueva venta con los datos pasados por parametro
        /// </summary>
        /// <param name="empleado">vendedor</param>
        /// <param name="cliente">comprador</param>
        /// <param name="carrito">lista de compra</param>
        /// <param name="cantidad">cantidades</param>
        /// <param name="fecha">fecha venta</param>
        /// <param name="precioTotal">precio total de venta</param>
        /// <returns>new venta</returns>
        public static VentasHistoricas CargarVenta(Empleado empleado, Cliente cliente, List<Producto> carrito, List<decimal> cantidad, string fecha, double precioTotal)
        {
            if (empleado != null && cliente != null && carrito != null && cantidad != null && !string.IsNullOrEmpty(fecha) && precioTotal>0)
            {
                return new VentasHistoricas(empleado, cliente, carrito, cantidad, fecha, precioTotal);
            }
            return null;
        }

        /// <summary>
        /// Dictionary con los empleados que vendieron
        /// </summary>
        /// <param name="empleado">empleado</param>
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
