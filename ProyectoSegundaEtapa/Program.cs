using System;
using System.Collections.Generic;

namespace ProyectoSegundaEtapa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Usuario usuario = new Usuario();
            usuario.Email = "correoprueba@gmail.com";
            usuario.Contraseña = "contraseña";
            Console.WriteLine("su correo ingresado es:"+usuario.Email);
            Console.WriteLine("su contraseña ingresada es:"+usuario.Contraseña);
            Console.WriteLine("Si desea revisar el inventario presione 1, caso contrario presione cualquier otra tecla");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                Celulares iphone = new Celulares();
                iphone.ModeloCelular = "Iphone 6s";
                iphone.Precio = 650;
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
                    Console.WriteLine(item.ModeloCelular+"\n"+ "Con un valor de:"+item.Precio);
                }

            }
        }
    }
}
