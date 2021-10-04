using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Producto
    {
        #region Atributos
        private int idProducto;
        private string nombre;
        private double precio;
        private ECategoria categoria;
        private string descripcion;
        private string marca;
        private decimal stock;
        private static int ultimoIdGenerado;        
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad redonly id
        /// </summary>
        public int IdProducto
        {
            get { return idProducto; }
        }

        /// <summary>
        /// Propiedad nombre producto
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }                 
            }
        }

        /// <summary>
        /// Propiedad precio producto
        /// </summary>
        public double Precio
        {
            get { return precio; }
            set 
            {
                if (value > 0)
                {
                    precio = value;
                }                
            }
        }

        /// <summary>
        /// Propiedad categoria producto
        /// </summary>
        public ECategoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        /// <summary>
        /// Propiedad descripcion producto
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    descripcion = value;
                }                
            }
        }

        /// <summary>
        /// Propiedad marca producto
        /// </summary>
        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    marca = value;
                }
            }
        }

        /// <summary>
        /// Propiedad stock producto
        /// </summary>
        public decimal Stock
        {
            get { return stock; }
            set
            {
                if (stock > -1)
                {
                    stock = value;
                }
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor static que inicializa el id
        /// </summary>
        static Producto()
        {
            ultimoIdGenerado = 19999;
        }

        /// <summary>
        /// Constructor completo de producto
        /// </summary>
        /// <param name="nombre">nombre producto</param>
        /// <param name="precio">precio producto</param>
        /// <param name="categoria">categoria producto</param>
        /// <param name="descripcion">descripcion producto</param>
        /// <param name="marca">marca producto</param>
        /// <param name="stock">stock producto</param>
        public Producto(string nombre, double precio, ECategoria categoria, string descripcion, string marca, decimal stock)
        {
            ultimoIdGenerado++;
            this.idProducto = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Stock = stock;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga operador + carga un new producto a la lista de productos
        /// </summary>
        /// <param name="productos">lista productos</param>
        /// <param name="producto">new producto</param>
        /// <returns>lista actualizada</returns>
        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            productos.Add(producto);
            return productos;
        }

        /// <summary>
        /// Crea un nuevo producto a partir de los datos pasados por parametros
        /// </summary>
        /// <param name="nombre">nombre producto</param>
        /// <param name="precio">precio producto</param>
        /// <param name="stock">stock producto</param>
        /// <param name="descripcion">descripcion producto</param>
        /// <param name="marca">marca producto</param>
        /// <param name="categoria">categoria producto</param>
        /// <returns>new producto</returns>
        public static Producto CrearProducto(string nombre, string precio, decimal stock, string descripcion, string marca, string categoria)
        {
            if (nombre != null && descripcion != null && stock > 0 && precio != null && marca != null && categoria != null)
            {
                double.TryParse(precio, out double auxPrecio);
                return new Producto(nombre, auxPrecio, Enum.Parse<ECategoria>(categoria), descripcion, marca, stock);
            }
            return null;
        }

        #endregion

    }
}
