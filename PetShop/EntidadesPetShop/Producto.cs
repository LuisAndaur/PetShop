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
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public ECategoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
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
            this.idProducto = ultimoIdGenerado;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.marca = marca;
            this.stock = stock;
        }
        #endregion

    }
}
