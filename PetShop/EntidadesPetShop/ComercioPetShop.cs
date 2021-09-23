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
        private static List<Administrador> administradores;
        private static Dictionary<string, string> usuarios;
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
            administradores = new List<Administrador>();
            usuarios = new Dictionary<string, string>();
        }
        #endregion


       

        #region Metodos
        public static void CargarListaClientes(List<Cliente> clientes)
        {
            clientes.Add(new Cliente("Maria", "Noriega", 30000));
            clientes.Add(new Cliente("Juan", "Lopez", 1000));
            clientes.Add(new Cliente("Patricia", "Gomez", 300));
            clientes.Add(new Cliente("Monica", "Antunez", 50000));
            clientes.Add(new Cliente("Alma", "Nuñez", 2500));
            clientes.Add(new Cliente("Pedro", "Gutierrez", 700));
            clientes.Add(new Cliente("Angel", "Ortega", 4500));
            clientes.Add(new Cliente("Lionel", "Messi", 15000));
            clientes.Add(new Cliente("Antonella", "Martinez", 6800));
            clientes.Add(new Cliente("Mauro", "Almada", 10000));
            clientes.Add(new Cliente("Nadia", "DiMaria", 450));
        }

        public static void CargarListaEmpleados(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("Luis", "Andaur", 100000));
            empleados.Add(new Empleado("Carla", "Olmedo", 100000));
            empleados.Add(new Empleado("Lucia", "Santamaria", 100000));
            empleados.Add(new Empleado("Pablo", "Sanchez", 100000));
            empleados.Add(new Empleado("Sandra", "Ojeda", 100000));
            empleados.Add(new Empleado("Lisa", "Simpson", 100000));
        }

        public static void CargarListaAdministradores(List<Administrador> administradores)
        {
            administradores.Add(new Administrador("Ezequiel", "Oggioni", 150000));
            administradores.Add(new Administrador("Lucas", "Rodriguez", 100000));
            administradores.Add(new Administrador("Juan", "Santos", 80000));
            administradores.Add(new Administrador("Carolina", "Scrofani", 80000));
        }

        public static void AgregarDictionaryUsuarios(Dictionary<string, string> usuarios)
        {
            usuarios.Add("Lucas", "asd123");
        }
        #endregion



    }
}
