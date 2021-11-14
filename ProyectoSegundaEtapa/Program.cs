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
                    Console.WriteLine("Bienvenido al inventario, seleccione que categoria desea visualizar");
                    Console.WriteLine("1.Celulares");
                    Console.WriteLine("2.Camaras");
                    Console.WriteLine("3.Televisores");
                    Console.WriteLine("otro numero salir.");
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 1)
                    {
                        //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                        Celulares iphone = new Celulares();
                        iphone.ModeloCelular = "Iphone 6s";
                        iphone.Precio = 250;
                        iphone.Cantidad = 30;

                        iphone.ModeloCelular = "Iphone 7";
                        iphone.Precio = 300;
                        iphone.Cantidad = 23;

                        iphone.ModeloCelular = "Iphone 8";
                        iphone.Precio = 389;
                        iphone.Cantidad = 10;

                        iphone.ModeloCelular = "Iphone 8 plus";
                        iphone.Precio = 420;
                        iphone.Cantidad = 25;

                        iphone.ModeloCelular = "Iphone X";
                        iphone.Precio = 475;
                        iphone.Cantidad = 53;

                        Celulares samsung = new Celulares();
                        samsung.ModeloCelular = "Samsung Galaxy Note8";
                        samsung.Precio = 500;
                        samsung.Cantidad = 32;

                        samsung.ModeloCelular = "Samsung Galaxy Note 9";
                        samsung.Precio = 670;
                        samsung.Cantidad = 12;

                        samsung.ModeloCelular = "Samsung Galaxy Note 10";
                        samsung.Precio = 700;
                        samsung.Cantidad = 32;

                        samsung.ModeloCelular = "Samsung Galaxy S10";
                        samsung.Precio = 890;
                        samsung.Cantidad = 28;

                        samsung.ModeloCelular = "Samsung Galaxy s10+";
                        samsung.Precio = 920;
                        samsung.Cantidad = 54;


                        Celulares motorola = new Celulares();
                        motorola.ModeloCelular = "Motorola Moto Tab G20";
                        motorola.Precio = 260;
                        motorola.Cantidad = 20;

                        motorola.ModeloCelular = "Motorola Moto G51";
                        motorola.Precio = 380;
                        motorola.Cantidad = 10;

                        motorola.ModeloCelular = "Motorola Moto G51";
                        motorola.Precio = 500;
                        motorola.Cantidad = 13
                            ;
                        motorola.ModeloCelular = "Motorola Moto E30";
                        motorola.Precio = 300;
                        motorola.Cantidad = 34;

                        motorola.ModeloCelular = "Motorola Moto E40";
                        motorola.Precio = 250;
                        motorola.Cantidad = 15;

                        Celulares realme = new Celulares();
                        realme.ModeloCelular = "Realme 7";
                        realme.Precio = 280;
                        realme.Cantidad = 50;
                        Celulares realme1 = new Celulares();
                        realme.ModeloCelular = "Realme 7 pro";
                        realme.Precio = 320;
                        realme.Cantidad = 12;
                        Celulares realme2 = new Celulares();
                        realme.ModeloCelular = "Realme 8";
                        realme.Precio = 355;
                        realme.Cantidad = 50;

                        Celulares xiaomi = new Celulares();
                        xiaomi.ModeloCelular = "Xiaomi Note 10";
                        xiaomi.Precio = 950;
                        xiaomi.Cantidad = 90;

                        List<Celulares> ListaCelulares = new List<Celulares>();
                        ListaCelulares.Add(iphone);
                        ListaCelulares.Add(samsung);
                        ListaCelulares.Add(xiaomi);
                        ListaCelulares.Add(motorola);
                        ListaCelulares.Add(realme);
                        //IMPRESION DE LA LISTA DE CELULARES QUE TIENEN HERENCIA DE INVENTARIO
                        Console.WriteLine("MODELOS DE CELULARES");
                        foreach (Celulares item in ListaCelulares)
                        {
                            Console.WriteLine(item.ModeloCelular + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay una catidad de:" + item.Cantidad + " telefonos");
                        }
                    }
                    else if (num2 == 2)
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
                        {
                            Console.WriteLine(item.ModeloCamara + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " camaras");
                        }
                    }
                    else if (num2 == 3)
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
                        {
                            Console.WriteLine(item.ModeloTelevisores + "\n" + "Con un valor de:" + item.Precio + "\n" + "Hay un catidad de:" + item.Cantidad + " televisores");
                        }
                    }
                    else
                        Console.WriteLine("programa finalizado.");

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