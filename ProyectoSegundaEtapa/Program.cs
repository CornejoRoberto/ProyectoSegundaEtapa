using System;
using System.Collections.Generic;

namespace ProyectoSegundaEtapa
{
    class Program
    {
        static void Main(string[] args)
        {

            string confirmar = "";
            int comparar = 0;
            do
            {
                Console.WriteLine("----BIENVENIDO A SPRITH INDUSTRRY'S----\n");
                        Console.WriteLine("Ingrese los siguientes datos para la creación de su cuenta de usuario: \n");
                        string User = IngresoNuevoUsuario_User();
                        string Correo = IngresoNuevoUsuario_Correo();
                        string Contraseña = IngresoNuevoUsuario_Contraseña();

                        Usuario nuevoUsuario1 = new Usuario(User, Correo, Contraseña);
                        Console.WriteLine($"****   Bienvenido {User}   ****");
                        Inventario();

                Console.WriteLine("Saliendo del sistema");
                Console.WriteLine("¿Deea acceder nuevamente? \nSi/No ");
                confirmar = Console.ReadLine();
                comparar = string.Compare(confirmar, "no", true);
            } while (comparar!=0);
        }

        public static string IngresoNuevoUsuario_User()
        {
            String User = "";
            Console.WriteLine("**  Ingrese su nombre de usuario  **\n");
            User = Console.ReadLine();
            User = VerificarUsuario(User);
            return User;
        }
        public static string IngresoNuevoUsuario_Correo()
        {
            string Correo = "";
            Console.WriteLine("**  Ingrese su correo electronico   **\n");
            Correo = Console.ReadLine();
            Correo = VerificarCorreo(Correo);
            return Correo;
        }
        public static string IngresoNuevoUsuario_Contraseña()
        {
            string Contraseña = "";
            Console.WriteLine("**  Ingrese su correo contraseña   **\n");
            Contraseña = Console.ReadLine();
            Contraseña = VerificarContraseña(Contraseña);
            return Contraseña;
        }

        private static string VerificarUsuario (string Usuario)
        {
            string respuesta = "";
            int compara = 0;
            Console.WriteLine("¿Es correcto su nombre de usuario? \nSi/No ");
            respuesta = Console.ReadLine();
            compara = string.Compare(respuesta, "si", true);

            if (compara == 0)
            {
                return Usuario;
            }
            else
            {
                Console.WriteLine("--Ingrese nuevamente-- \n");
                string UsuarioNuevo = Console.ReadLine();
                Usuario = UsuarioNuevo;
                return Usuario;
            }
        }

        private static string VerificarCorreo(string Correo)
        {
            string respuesta = "";
            int compara = 0;
            Console.WriteLine("¿Es correcto su correo Electronico? \nSi/No ");
            respuesta = Console.ReadLine();
            compara=string.Compare(respuesta, "si", true);

            if (compara == 0)
            {
                return Correo;
            }
            else
            {
                Console.WriteLine("--Ingrese nuevamente-- \n");
                string CorreoNuevo = Console.ReadLine();
                Correo = CorreoNuevo;
                return Correo;
            }
        }
        private static string VerificarContraseña(string Contraseña)
        {
            string respuesta = "";
            int compara = 0;
            Console.WriteLine("¿Es correcta su contraseña? \nSi/No ");
            respuesta = Console.ReadLine();
            compara = string.Compare(respuesta, "si", true);

            if (compara == 0)
            {
                return Contraseña;
            }
            else
            {
                Console.WriteLine("--Ingrese nuevamente-- \n");
                string ContraseñaNueva = Console.ReadLine();
                Contraseña = ContraseñaNueva;
                return Contraseña;
            }
        }

        public static void Inventario()
        {
            int seleccion = 0;
            do
            {
                Console.WriteLine("Ingreso al inventario, seleccione que categoria desea visualizar\n1. Celulare\n2. Camaras\n3. Televisores\n");
                try
                {
                    seleccion = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("******Se ingresó un valor incorrecto. Ingrese nuevamente******\n*");
                    seleccion = 0;
                }

            } while (seleccion != 1 && seleccion != 2 && seleccion != 3);

            switch (seleccion)
            {
                case 1:
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                    Celulares();
                    break;

                case 2:
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE CAMARAS Y PRECIOS
                    Camaras();
                    break;
                case 3:
                    Televisores();
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE TELEVISORES Y PRECIOS
                    break;
            }
        }


        public static void Celulares()
        {

            Celulares iphone = new Celulares();
            iphone.ModeloCelular = "Iphone 6s";
            iphone.Precio = 650;
            iphone.Cantidad = 30;
            Celulares samsung = new Celulares();
            samsung.ModeloCelular = "Samsung Galaxy Note";
            samsung.Precio = 800;
            samsung.Cantidad = 350;
            Celulares motorola = new Celulares();
            motorola.ModeloCelular = "Motorola G2";
            motorola.Precio = 260;
            motorola.Cantidad = 20;
            Celulares xiaomi = new Celulares();
            xiaomi.ModeloCelular = "Xiaomi Note 10";
            xiaomi.Precio = 950;
            xiaomi.Cantidad = 45;
            List<Celulares> ListaCelulares = new List<Celulares>();
            ListaCelulares.Add(iphone);
            ListaCelulares.Add(samsung);
            ListaCelulares.Add(xiaomi);
            ListaCelulares.Add(motorola);

            //IMPRESION DE LA LISTA DE CELULARES QUE TIENEN HERENCIA DE INVENTARIO
            Console.WriteLine("MODELOS DE CELULARES");
            foreach (Celulares item in ListaCelulares)
                Console.WriteLine(item.ModeloCelular + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " telefonos");
        }

        public static void Camaras()
        {
            Camaras nikon = new Camaras();
            nikon.ModeloCamara = "Nikon D3500";
            nikon.Precio = 840;
            nikon.Cantidad = 40;
            Camaras canon = new Camaras();
            canon.ModeloCamara = "Canon M50";
            canon.Precio = 950;
            canon.Cantidad = 30;
            List<Camaras> ListaCamaras = new List<Camaras>();
            ListaCamaras.Add(nikon);
            ListaCamaras.Add(canon);
            Console.WriteLine("MODELOS DE CAMARAS");
            foreach (Camaras item in ListaCamaras)
                Console.WriteLine(item.ModeloCamara + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " camaras");
        }

        public static void Televisores()
        {
            Televisores lg = new Televisores();
            lg.ModeloTelevisores = "LG OLED Z1";
            lg.Precio = 965;
            lg.Cantidad = 65;
            Televisores panasonic = new Televisores();
            panasonic.ModeloTelevisores = "Panasonic Tx-58Gx700E";
            panasonic.Precio = 890;
            panasonic.Cantidad = 80;
            Televisores tcl = new Televisores();
            tcl.ModeloTelevisores = "TCL 42S6500";
            tcl.Precio = 599;
            tcl.Cantidad = 78;
            List<Televisores> ListaTelevisores = new List<Televisores>();
            ListaTelevisores.Add(lg);
            ListaTelevisores.Add(panasonic);
            ListaTelevisores.Add(tcl);
            Console.WriteLine("MODELOS DE TELEVISORES");
            foreach (Televisores item in ListaTelevisores)
                Console.WriteLine(item.ModeloTelevisores + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " televisores");
        }
    } 
}