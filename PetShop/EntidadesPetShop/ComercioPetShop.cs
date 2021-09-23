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
        }
        #endregion
              

        #region Metodos
        public static void CargarListaClientes(List<Cliente> clientes)
        {
            clientes.Add(new Cliente("Maria", "Noriega", "33694911", 27336949114, 30000));
            clientes.Add(new Cliente("Juan", "Lopez", "42053266", 27420532666, 1000));
            clientes.Add(new Cliente("Patricia", "Gomez", "39971941", 27399719416, 300));
            clientes.Add(new Cliente("Monica", "Antunez", "36631583", 27366315832, 50000));
            clientes.Add(new Cliente("Alma", "Nuñez", "23195639", 27231956390, 2500));
            clientes.Add(new Cliente("Pedro", "Gutierrez", "40685744", 27406857447, 700));
            clientes.Add(new Cliente("Angel", "Ortega", "41264922", 20412649223, 4500));
            clientes.Add(new Cliente("Lionel", "Messi", "32407271", 20324072714, 15000));
            clientes.Add(new Cliente("Antonella", "Martinez", "38747220", 27387472207, 6800));
            clientes.Add(new Cliente("Mauro", "Almada", "34636305", 20346363054, 10000));
            clientes.Add(new Cliente("Nadia", "DiMaria", "20345033", 27203450333, 450));
            clientes.Add(new Cliente("Pablo", "Sanchez", "43144306", 27431443063, 67450));
            clientes.Add(new Cliente("Sandra", "Ojeda", "40719653", 27407196534, 850));
            clientes.Add(new Cliente("Lisa", "Simpson", "28854286", 27288542863, 11450));
            clientes.Add(new Cliente("Lucia", "Santamaria", "37821737", 27378217373, 2230));
            clientes.Add(new Cliente("Carla", "Olmedo", "42217764", 26422177649, 100000));
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



    }
}
