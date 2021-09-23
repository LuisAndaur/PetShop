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
        private string rol;
        private static int ultimoIdGenerado;
        #endregion

        #region Propiedades
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
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

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        #endregion

        #region Contructor
        static Usuario()
        {
            ultimoIdGenerado = 0;
        }

        public Usuario(string nombreUsuario, string contraseña, string rol)
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
