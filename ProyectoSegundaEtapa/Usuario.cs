using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_u_y_proyecto_xd
{
    public class Usuario
    {
        //CREACIÓN DE CLASE USUARIO

        public Usuario(string User, string Email, string Contraseña)
        {
            this.User = User;
            this.Email = Email;
            this.Contraseña = Contraseña;
        }


        public string User { get; }
        public string Email { get; }
        public string Contraseña { get; }
    }
}
