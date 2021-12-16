using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSegundaEtapa
{
    public class Proxy
    {
        public Proxy()
        {
        }

        public interface Privado
        {
            void Peticion(int peti);
        }
        public class ProxySeguro: Privado
        {
            private CPrivado nombre;
            public void Peticion(int peti)
            {
                string password;
                password = Console.ReadLine();
                if (password == "admin123")
                {
                    if (nombre == null)
                    {
                        Console.WriteLine("----Ingresando en modo Empresa----");
                        nombre = new CPrivado();
                    }
                    if (peti == 1)
                        nombre.NombreSecreto();
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }

            }

        }
        private class CPrivado
        {
            public void NombreSecreto()
            {
                Console.WriteLine("LAS GANANCIAS PRIVADAS DEL MES DE DICIEMBRE SON : ");
                Console.WriteLine("\n");
                Console.WriteLine("CAMARAS: $8,976");
                Console.WriteLine("CELULARES: $10,987");
                Console.WriteLine("TELEVISORES: $78,890");
            }
        }
    }
}    
    

    

