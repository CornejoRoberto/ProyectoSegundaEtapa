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
        public string Email { get; set; }
        public string Contraseña { get; set; }

        public void UsuarioContraseña(string Contra)
        {
            string RepiteContra = "";
            if (Contra == Contraseña)
            {
                Console.WriteLine("Continue");
            }
            else
            {
                do
                {
                    Console.WriteLine("Ingrese la contraseña nuevamente");
                    RepiteContra = Console.ReadLine();
                } while (RepiteContra != Contraseña);
                Console.WriteLine("Continue");
            }
        }
        public void UsuarioNombre(string Username)
        {
            string RepiteUsuario = "";
            if (Username == User)
            {
                Console.WriteLine("Continue");
            }
            else
            {
                do
                {
                    Console.WriteLine("Ingrese el usuario nuevamete");
                    RepiteUsuario = Console.ReadLine();
                } while (RepiteUsuario != User);
                Console.WriteLine("Continue");
            }
        }

        public void Muestra()
        {

        }
    }
}
