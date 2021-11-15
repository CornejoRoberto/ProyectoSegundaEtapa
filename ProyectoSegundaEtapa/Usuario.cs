using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSegundaEtapa
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

        public string User { get; set; }
        public string Email { get; }
        public string Contraseña { get; set; }
    }
}
