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
        private static long cuit;
        private static string razonSocial;
        private static List<Cliente> clientes;
        private static List<Empleado> empleados;
        private static List<Usuario> usuarios;
        private static List<Producto> productos;
        private static List<Ventas> ventas;
        #endregion

        #region Constructor
        static ComercioPetShop()
        {
            nombre = "Piluso";
            direccion = "Av. Siempre Viva 742";
            cuit = 30987665314;
            razonSocial = "Pet Shop";
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            usuarios = new List<Usuario>();
            productos = new List<Producto>();
            ventas = new List<Ventas>();
        }
        #endregion

        
        #region Metodos
        public static void CargarListaClientes(List<Cliente> clientes)
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

        public static void CargarListaEmpleados(List<Empleado> empleados, List<Usuario> usuarios)
        {
            empleados.Add(new Empleado("Ezequiel", "Oggioni", "42217620", 20422176209, usuarios[0], 250000));
            empleados.Add(new Empleado("Lucas", "Rodriguez", "42385648", 20423856484, usuarios[1], 250000));
            empleados.Add(new Empleado("Juan", "Santos", "41481920", 20414819207, usuarios[2], 150000));
            empleados.Add(new Empleado("Carolina", "Scrofani", "42385227", 27423852270, usuarios[3], 150000));
            empleados.Add(new Empleado("Luis", "Andaur", "33009897", 20330098979, usuarios[4], 150000));
        }

        public static void CargarUsuarios(List<Usuario> usuarios)
        {
            usuarios.Add(new Usuario("eoggioni", "42217620", ERol.Administrador));
            usuarios.Add(new Usuario("lrodriguez", "42385648", ERol.Administrador));
            usuarios.Add(new Usuario("jsantos", "41481920", ERol.Staff));
            usuarios.Add(new Usuario("cscrofani", "42385227", ERol.Staff));
            usuarios.Add(new Usuario("landaur", "33009897", ERol.Staff));
        }
        #endregion

        public static void CargarProductos(List<Producto> productos)
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

        public static void CargarVentas(List<Ventas> ventas, List<Empleado> empleados, List<Cliente> clientes, List<Producto> productos)
        {
            ventas.Add(new Ventas(empleados[3], clientes[2], productos[4], 2, productos[4].Precio*2));
            ventas.Add(new Ventas(empleados[0], clientes[5], productos[12], 1, productos[12].Precio));
            ventas.Add(new Ventas(empleados[1], clientes[7], productos[7], 3, productos[7].Precio*3));
            ventas.Add(new Ventas(empleados[2], clientes[10], productos[5], 2, productos[5].Precio*2));
            ventas.Add(new Ventas(empleados[3], clientes[8], productos[2], 2, productos[2].Precio*2));
            ventas.Add(new Ventas(empleados[1], clientes[5], productos[10], 1, productos[10].Precio));
            ventas.Add(new Ventas(empleados[4], clientes[1], productos[14], 2, productos[14].Precio*2));
            ventas.Add(new Ventas(empleados[2], clientes[12], productos[9], 1, productos[9].Precio));
            ventas.Add(new Ventas(empleados[0], clientes[15], productos[16], 1, productos[16].Precio));
            ventas.Add(new Ventas(empleados[1], clientes[4], productos[3], 2, productos[3].Precio*2));
        }

    }
}
