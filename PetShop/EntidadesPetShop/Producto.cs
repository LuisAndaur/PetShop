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
        private int stock;
        private static int ultimoIdGenerado;        
        #endregion

        #region Propiedades
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }                 
            }
        }

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

        public ECategoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    descripcion = value;
                }                
            }
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    marca = value;
                }
            }
        }

        public int Stock
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
        static Producto()
        {
            ultimoIdGenerado = 19999;
        }

        public Producto(string nombre, double precio, ECategoria categoria, string descripcion, string marca, int stock)
        {
            ultimoIdGenerado++;
            this.IdProducto = ultimoIdGenerado;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Stock = stock;
        }
        #endregion

    }
}
