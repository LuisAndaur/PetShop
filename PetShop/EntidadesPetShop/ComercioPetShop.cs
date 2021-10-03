using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public static class ComercioPetShop
    {
        #region Atributos
        private static string nombre;
        private static string direccion;
        private static double cuit;
        private static string razonSocial;
        private static double caja;

        private static List<Cliente> clientes;
        private static List<Administrador> administradores;
        private static List<Staff> staff;
        private static List<Producto> productos;
        private static List<VentasHistoricas> ventasHistoricas;
        #endregion

        #region Propiedades
        public static string Nombre { get { return nombre; } }
        public static string Direccion { get { return direccion; } }
        public static double Cuit { get { return cuit; } }
        public static string RazonSocial { get { return razonSocial; } }
        public static double MiCaja
        {
            get { return caja; }
            set
            {
                if (value > 0)
                {
                    caja = value;
                }
            }
        }

        public static List<Cliente> ListaClientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        public static List<Administrador> ListaAdministradores
        {
            get { return administradores; }
            set
            {
                if (value != null)
                {
                    administradores = value;
                }
            }
        }

        public static List<Staff> ListaStaff
        {
            get { return staff; }
            set
            {
                if (value != null)
                {
                    staff = value;
                }
            }
        }
        public static List<Producto> ListaProductos
        {
            get { return productos; }
            set
            {
                if (value != null)
                {
                    productos = value;
                }
            }
        }

        public static List<VentasHistoricas> ListaVentasHistoricas
        {
            get { return ventasHistoricas; }
            set
            {
                if (value != null)
                {
                    ventasHistoricas = value;
                }
            }
        }
        #endregion

        #region Constructor
        static ComercioPetShop()
        {
            nombre = "Piluso";
            direccion = "Av. Siempre Viva 742";
            cuit = 30987665314;
            razonSocial = "Pet Shop";
            clientes = new List<Cliente>();
            administradores = new List<Administrador>();
            staff = new List<Staff>();
            productos = new List<Producto>();
            ventasHistoricas = new List<VentasHistoricas>();

            CargarListaClientes();
            CargarListaAdministradores();
            CargarListaStaff();
            CargarProductos();
            //CargarVentas();
        }
        #endregion

        #region ListasHardcode
        private static void CargarListaClientes()
        {
            clientes.Add(new Cliente("Maria", "Noriega", "33694911", 27336949114));
            clientes.Add(new Cliente("Juan", "Lopez", "42053266", 27420532666));
            clientes.Add(new Cliente("Patricia", "Gomez", "39971941", 27399719416));
            clientes.Add(new Cliente("Monica", "Antunez", "36631583", 27366315832));
            clientes.Add(new Cliente("Alma", "Nuñez", "23195639", 27231956390));
            clientes.Add(new Cliente("Pedro", "Gutierrez", "40685744", 27406857447));
            clientes.Add(new Cliente("Angel", "Ortega", "41264922", 20412649223));
            clientes.Add(new Cliente("Lionel", "Messi", "32407271", 20324072714));
            clientes.Add(new Cliente("Antonella", "Martinez", "38747220", 27387472207));
            clientes.Add(new Cliente("Mauro", "Almada", "34636305", 20346363054));
            clientes.Add(new Cliente("Nadia", "DiMaria", "20345033", 27203450333));
            clientes.Add(new Cliente("Pablo", "Sanchez", "43144306", 27431443063));
            clientes.Add(new Cliente("Sandra", "Ojeda", "40719653", 27407196534));
            clientes.Add(new Cliente("Lisa", "Simpson", "28854286", 27288542863));
            clientes.Add(new Cliente("Lucia", "Santamaria", "37821737", 27378217373));
            clientes.Add(new Cliente("Carla", "Olmedo", "42217764", 26422177649));
        }

        private static void CargarListaAdministradores()
        {
            administradores.Add(new Administrador("Ezequiel", "Oggioni", "42217620", 20422176209, "eoggioni", "42217620", 250000));
            administradores.Add(new Administrador("Lucas", "Rodriguez", "42385648", 20423856484, "lrodriguez", "42385648", 250000));
        }

        private static void CargarListaStaff()
        {
            staff.Add(new Staff("Juan", "Santos", "41481920", 20414819207, "jsantos", "41481920", 150000));
            staff.Add(new Staff("Carolina", "Scrofani", "42385227", 27423852270, "cscrofani", "42385227", 150000));
            staff.Add(new Staff("Luis", "Andaur", "33009897", 20330098979, "landaur", "33009897", 150000));
        }
        private static void CargarProductos()
        {
            productos.Add(new Producto("Monaco Cuadrille L", 2899.90, ECategoria.Cama, "Casita acolchada y desarmable", "Puppy", 5));
            productos.Add(new Producto("MDF Carpa", 2915.40, ECategoria.Cama, "Carpita muy suave, cómoda y calentita", "MDF", 3));
            productos.Add(new Producto("Active mind", 4650.33, ECategoria.Alimento, "Provee nutrición de avanzada manteniéndolos sanos y activos", "Purina", 6));
            productos.Add(new Producto("Mummy Pro", 10490.50, ECategoria.Alimento, "Alimento completo y balanceado", "Purina", 2));
            productos.Add(new Producto("Super Ranch", 422.80, ECategoria.Alimento, "Alpiste alimento para aves x750grs", "Nelsoni", 9));
            productos.Add(new Producto("Bife gigante", 288.45, ECategoria.Juguete, "Juguetes para perros con sonido con forma de churrasco", "SuperPet", 4));
            productos.Add(new Producto("Super raton", 176.25, ECategoria.Juguete, "Raton con sisal y sonido", "SuperPet", 5));
            productos.Add(new Producto("Antiparasitario plus", 403.20, ECategoria.Farmacia, "Antiparasitario de espectro total y una sola toma", "Basquen", 2));
            productos.Add(new Producto("Aquadent", 2311.60, ECategoria.Farmacia, "Dental Plax Antiséptico Bucal", "Virbac", 3));
            productos.Add(new Producto("Grava gris", 1251.65, ECategoria.Higiene, "Impide cualquier efecto adverso sobre el agua", "SuperPet", 6));
            productos.Add(new Producto("Escaleta", 1870.25, ECategoria.Juguete, "Escalada interactiva para aves", "SuperPet", 2));
            productos.Add(new Producto("Marlo sanitario", 632.75, ECategoria.Higiene, "Cuidado sanitario para roedores", "Nelsoni", 3));
            productos.Add(new Producto("Tetra fin", 3354.10, ECategoria.Alimento, "Alimento para peces carassius y otros peces de agua fría.", "Golsfish", 5));
            productos.Add(new Producto("Bedding L", 2081.30, ECategoria.Cama, "Cama de doble cara y reversible para conejo", "Golsfish", 1));
            productos.Add(new Producto("Shampoo de algas", 1139.60, ECategoria.Higiene, "Shampoo de algas abrillantador de higiene en general", "Osspret", 4));
            productos.Add(new Producto("Peine Plats", 269.30, ECategoria.Higiene, "Peine manopla de goma", "SuperPet", 3));
            productos.Add(new Producto("Peine Plats", 364.20, ECategoria.Higiene, "Regulador de los niveles de pH y potasio", "Nutrafin", 7));
            productos.Add(new Producto("Baño arena", 486.85, ECategoria.Higiene, "Baños de polvo imprescindibles para su pelaje suelto y esponjoso", "Zootec", 1));
        }

        private static void CargarVentas()
        {
            //ventasHistoricas.Add(new VentasHistoricas(empleados[3], clientes[2], productos[4], 2, productos[4].Precio*2));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[0], clientes[5], productos[12], 1, productos[12].Precio));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[1], clientes[7], productos[7], 3, productos[7].Precio*3));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[2], clientes[10], productos[5], 2, productos[5].Precio*2));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[3], clientes[8], productos[2], 2, productos[2].Precio*2));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[1], clientes[5], productos[10], 1, productos[10].Precio));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[4], clientes[1], productos[14], 2, productos[14].Precio*2));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[2], clientes[12], productos[9], 1, productos[9].Precio));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[0], clientes[15], productos[16], 1, productos[16].Precio));
            //ventasHistoricas.Add(new VentasHistoricas(empleados[1], clientes[4], productos[3], 2, productos[3].Precio*2));
        }
        #endregion

        #region Metodos

        #region Empleados

        /// <summary>
        /// Verifica si los datos ingresados pertenecen a empleados administradores
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns></returns>
        public static Administrador LoguearAdministrador(string nombreUsuario, string pass)
        {
            if (ValidarCamposIngresados(nombreUsuario, pass))
            {
                foreach (Administrador item in administradores)
                {
                    if (item.NombreUsuario.Trim().ToLower() == nombreUsuario.Trim().ToLower() && item.Pass.Trim() == pass.Trim())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Verifica si los datos ingresados pertenecen a empleados staff
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns></returns>
        public static Staff LoguearStaff(string nombreUsuario, string pass)
        {
            if (ValidarCamposIngresados(nombreUsuario, pass))
            {
                foreach (Staff item in staff)
                {
                    if (item.NombreUsuario.Trim().ToLower() == nombreUsuario.Trim().ToLower() && item.Pass.Trim() == pass.Trim())
                    {
                        return item;
                    }
                }
            }
            return null;
        }


        private static bool ValidarCamposIngresados(string nombreUsuario, string pass)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(pass))
            {
                return false;
            }
            return true;
        }

        public static bool ExisteAdmin(int id)
        {
            foreach (Administrador item in administradores)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static Administrador ObtenerAdmin(int id)
        {
            foreach (Administrador item in administradores)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool ExisteStaff(int id)
        {
            foreach (Staff item in staff)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static Staff ObtenerStaff(int id)
        {
            foreach (Staff item in staff)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void EliminarStaff(int id)
        {
            foreach (Staff item in staff)
            {
                if (item.Id == id)
                {
                    staff.Remove(item);
                    break;
                }
            }
        }

        public static void EliminarAdmin(int id)
        {
            foreach (Administrador item in administradores)
            {
                if (item.Id == id)
                {
                    administradores.Remove(item);
                    break;
                }
            }
        }

        public static void EditarAdmin(int id, string nombre, string apellido, string dni, string cuil, string sueldo)
        {
            string nombreUsuario;
            if (id > 0 && nombre != null && apellido != null && dni != null && cuil != null && sueldo != null)
            {
                double.TryParse(cuil, out double auxCuil);
                double.TryParse(sueldo, out double auxSueldo);
                nombreUsuario = Empleado.GenerarNombreUsuario(nombre, apellido);

                foreach (Administrador item in administradores)
                {
                    if (item.Id == id)
                    {
                        item.Nombre = nombre;
                        item.Apellido = apellido;
                        item.Dni = dni;
                        item.Cuil = auxCuil;
                        item.Sueldo = auxSueldo;
                        item.NombreUsuario = nombreUsuario;
                        item.Pass = dni;
                    }
                }
            }
        }

        public static void EditarStaff(int id, string nombre, string apellido, string dni, string cuil, string sueldo)
        {
            string nombreUsuario;
            if (id > 0 && nombre != null && apellido != null && dni != null && cuil != null && sueldo != null)
            {
                double.TryParse(cuil, out double auxCuil);
                double.TryParse(sueldo, out double auxSueldo);
                nombreUsuario = Empleado.GenerarNombreUsuario(nombre, apellido);

                foreach (Staff item in staff)
                {
                    if (item.Id == id)
                    {
                        item.Nombre = nombre;
                        item.Apellido = apellido;
                        item.Dni = dni;
                        item.Cuil = auxCuil;
                        item.Sueldo = auxSueldo;
                        item.NombreUsuario = nombreUsuario;
                        item.Pass = dni;
                    }
                }
            }
        }

        #endregion

        #region Clientes

        public static Cliente ObtenerCliente(int id)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }


        public static void EditarCliente(int id, string nombre, string apellido, string dni, string cuil)
        {
            if (id > 0 && nombre != null && apellido != null && dni != null && cuil != null)
            {
                double.TryParse(cuil, out double auxCuil);

                foreach (Cliente item in clientes)
                {
                    if (item.Id == id)
                    {
                        item.Nombre = nombre;
                        item.Apellido = apellido;
                        item.Dni = dni;
                        item.Cuil = auxCuil;                       
                    }
                }
            }
        }

        public static void EliminarCliente(int id)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Id == id)
                {
                    clientes.Remove(item);
                    break;
                }
            }
        }


        #endregion


        #region Productos

        public static Producto ObtenerProducto(int id)
        {
            foreach (Producto item in productos)
            {
                if (item.IdProducto == id)
                {
                    return item;
                }
            }
            return null;
        }       


        public static void EditarProducto(int id, string nombre, string descripcion, decimal stock, string precio, string marca, string categoria)
        {
            if (id > 0 && nombre != null && descripcion != null && stock > 0 && precio != null && marca != null && categoria != null)
            {
                double.TryParse(precio, out double auxPrecio);

                foreach (Producto item in productos)
                {
                    if (item.IdProducto == id)
                    {
                        item.Nombre = nombre;
                        item.Descripcion = descripcion;
                        item.Stock = stock;
                        item.Precio = auxPrecio;
                        item.Marca = marca;
                        item.Categoria = Enum.Parse<ECategoria>(categoria);
                    }
                }
            }
        }

        public static void EliminarProducto(int id)
        {
            foreach (Producto item in productos)
            {
                if (item.IdProducto == id)
                {
                    productos.Remove(item);
                    break;
                }
            }
        }

        #endregion




        #endregion
    }

}   

