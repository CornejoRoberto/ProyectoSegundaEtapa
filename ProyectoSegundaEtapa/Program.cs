using ProyectoSegundaEtapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_u_y_proyecto_xd
{
    class Program
    {

        static void Main(string[] args)
        {
            int entrada = 0;
            string confirmar = "", UsuarioCorrecto = " ", ContrasennaCorrecta = " ";
            int comparar = 0, seleccion = 0;
            Console.WriteLine("----BIENVENIDO A SPRITH INDUSTRRY'S----\n");
            Console.WriteLine("SI DESEA ENTRAR EN MODO EMPRESA SELECCIONE 1, SI DESEA INGRESAR EN MODO CLIENTE SELECCIONE 2");
            entrada = int.Parse(Console.ReadLine());
            //ENTRADA AL MODO EMPRESA MEDIANTE AL PROXY
            if (entrada == 1)
            {
                Console.WriteLine("Ingrese su contraseña de empresa");
                //EJECUTAMOS NUESTRO PROXY PARA ENTRAR A LA BASE DE DATOS PRIVADA DE LA EMPRESA
                Proxy.Privado privado = new Proxy.ProxySeguro();
                privado.Peticion(1);
            }
            else
            Console.WriteLine("----Ingresando en modo cliente----\n");
            Console.WriteLine("Ingrese los siguientes datos para la creación de su cuenta de usuario: ");
            ValidarUsuario validarUsuario = new ValidarUsuario();
            Console.WriteLine("\nIngrese su nombre de usuario");
            string User = validarUsuario.IngresoUsuario_User();
            Console.WriteLine("\nIngrese su E-MAIL");
            string Correo = validarUsuario.IngresoUsuario_Correo();
            Console.WriteLine("\nIngrese su Contraseña");
            string Contrasenna = validarUsuario.IngresoUsuario_Contrasenna();
            Usuario nuevoUsuario1 = new Usuario(User, Correo, Contrasenna);
            Console.WriteLine($"****   Bienvenido {User}   ****");
            InventarioProductos inventarioProductos = new InventarioProductos();
            Console.WriteLine("Ingreso al inventario, seleccione que categoria desea visualizar\n1. Celulares\n2. Camaras\n3. Televisores\n");
            inventarioProductos.Inventario();
            
            do
            {
                while (comparar == 1)
                {
                    Console.WriteLine("----BIENVENIDO A SPRITH INDUSTRRY'S----\n");
                    Console.WriteLine("Ingrese los siguientes datos para acceder a su cuenta de usuario: \n");
                    Console.WriteLine("\nIngrese su nombre de usuario");
                    string Username = validarUsuario.IngresoUsuario_User();
                    Console.WriteLine("\nIngrese su contraseña");
                    string Password = validarUsuario.IngresoUsuario_Contrasenna();
                    do 
                    {
                        if (Username != UsuarioCorrecto && Password != ContrasennaCorrecta)
                        {
                            Console.WriteLine("*****Algún dato fue ingresado de manera erronea, intente nuevamente*****");
                            Console.WriteLine("\nIngrese su nombre de usuario nuevamente");
                            Username = validarUsuario.IngresoUsuario_User();
                            Console.WriteLine("\nIngrese su contraseña nuevamente");
                            Password = validarUsuario.IngresoUsuario_Contrasenna();
                        }
                        UsuarioCorrecto = nuevoUsuario1.User;
                        ContrasennaCorrecta = nuevoUsuario1.Contraseña;
                    } while (Username != UsuarioCorrecto && Password != ContrasennaCorrecta);

                    Console.WriteLine("*******************************");
                    Console.WriteLine($"****   Bienvenido {User}   ****");
                    Console.WriteLine("*******************************");

                    Console.WriteLine("Ingreso al inventario, seleccione que categoria desea visualizar\n1. Celulares\n2. Camaras\n3. Televisores\n");
                    inventarioProductos.Inventario();

                }
                Console.WriteLine("Saliendo del sistema");
                Console.WriteLine("¿Deea acceder nuevamente? \nSi/No ");
                confirmar = Console.ReadLine();
                comparar = string.Compare(confirmar, "no", true);
            } while (comparar != 0);

        }
    }
}
