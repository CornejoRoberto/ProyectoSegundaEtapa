using System;
using System.Collections.Generic;

namespace ProyectoSegundaEtapa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            
            Console.WriteLine("----BIENVENIDO A SPRITH INDUSTRRY'S----\n");

            Console.WriteLine("Ingrese 1 si es nuevo usuario o ingrese 2 si ya posee una cuenta ");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Ingrese los siguientes datos para la creación de su nueva cuenta de usuario: \n");
                    string User = IngresoNuevoUsuario_User();
                    string Correo = IngresoNuevoUsuario_Correo();
                    string Contraseña = IngresoNuevoUsuario_Contraseña();

                    Usuario nuevoUsuario1 = new Usuario(User, Correo, Contraseña);
                    
                    Console.WriteLine($"****   Bienvenido {User}   ****");
                    //Metodo para entrar al programa en si 
                    break;
                case 2:
                    Console.WriteLine("**Ingrese los datos requeridos para continuar**\n");

                    string Username= IngresoUsuario_name();
                    string Contra = IngresoUsuario_contra();
                    //nuevoUsuario1.UsuarioNombre(User);
                    Console.WriteLine();
                    //
                    Console.WriteLine("Si desea revisar el inventario presione 1, caso contrario presione cualquier otra tecla");
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 1)
                    {
                        //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                        Celulares iphone = new Celulares();
                        iphone.ModeloCelular = "Iphone 6s";
                        iphone.Precio = 650;
                        iphone.Cantidad = 30;
                        Celulares samsung = new Celulares();
                        samsung.ModeloCelular = "Samsung Galaxy Note";
                        samsung.Precio = 800;
                        Celulares motorola = new Celulares();
                        motorola.ModeloCelular = "Motorola G2";
                        motorola.Precio = 260;
                        motorola.Cantidad = 20;
                        Celulares xiaomi = new Celulares();
                        xiaomi.ModeloCelular = "Xiaomi Note 10";
                        xiaomi.Precio = 950;
                        List<Celulares> ListaCelulares = new List<Celulares>();
                        ListaCelulares.Add(iphone);
                        ListaCelulares.Add(samsung);
                        ListaCelulares.Add(xiaomi);
                        ListaCelulares.Add(motorola);
                        //IMPRESION DE LA LISTA DE CELULARES QUE TIENEN HERENCIA DE INVENTARIO
                        foreach (Celulares item in ListaCelulares)
                        {
                            Console.WriteLine(item.ModeloCelular + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " telefonos");
                        }
                    }
                        break;
                default:

                    break;

            }

           
        }
        public static void General()
        {

        }
        public static string IngresoUsuario_name()
        {
            string Username = "";
            Console.WriteLine("**  Ingrese su nombre de usuario  **\n");
            Username = Console.ReadLine();
            return Username;
        }
        public static string IngresoUsuario_contra()
        {
            string contra = "";
            Console.WriteLine("**  Ingrese su contraseña  **\n");
            contra = Console.ReadLine();
            return contra;
        }

        public static string IngresoNuevoUsuario_User()
        {
            String User = "";
            Console.WriteLine("**  Ingrese su nombre de usuario  **\n");
            User = Console.ReadLine();
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
            return Contraseña;
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
    }
}

/*
            Console.WriteLine("Si desea revisar el inventario presione 1, caso contrario presione cualquier otra tecla");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                Celulares iphone = new Celulares();
                iphone.ModeloCelular = "Iphone 6s";
                iphone.Precio = 650;
                iphone.Cantidad= 30;
                Celulares samsung = new Celulares();
                samsung.ModeloCelular = "Samsung Galaxy Note";
                samsung.Precio = 800;
                
                Celulares xiaomi = new Celulares();
                xiaomi.ModeloCelular = "Xiaomi Note 10";
                xiaomi.Precio = 950;
                List<Celulares> ListaCelulares = new List<Celulares>();
                ListaCelulares.Add(iphone);
                ListaCelulares.Add(samsung);
                ListaCelulares.Add(xiaomi);
                //IMPRESION DE LA LISTA DE CELULARES QUE TIENEN HERENCIA DE INVENTARIO
                foreach (Celulares item in ListaCelulares)
                {
                    Console.WriteLine(item.ModeloCelular+"\n"+ "Con un valor de:"+item.Precio+"\n"+ "Hay un catidad de:" +item.Cantidad+" telefonos");
                }

            }*/