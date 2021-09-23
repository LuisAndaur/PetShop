using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPetShop
{
    public class Usuario
    {
        #region Atributos
        private string nombreUsuario;
        private string contraseña;
        private int idUsuario;
        private ERol rol;
        private static int ultimoIdGenerado;
        #endregion

        #region Propiedades
        public int IdUsuario
        {
            get { return idUsuario; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public ERol Rol
        {
            get { return rol; }
        }

        #endregion

        #region Contructor
        static Usuario()
        {
            ultimoIdGenerado = 0;
        }

        public Usuario(string nombreUsuario, string contraseña, ERol rol)
        {
            ultimoIdGenerado++;
            this.idUsuario = ultimoIdGenerado;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }

        #endregion
    }
}
