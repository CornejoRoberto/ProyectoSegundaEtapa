using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSegundaEtapa
{
    //HERENCIA DE INVENTARIO
    class Celulares:Inventario
    {
        //CREACIÓN DE MODELOS DE CELULAR Y SU PRECIO
        public string ModeloCelular { get; set; }
        public int Precio { get; set; }
        public Celulares()
        {
        }
      public void InventarioPortables()
        {
        }
    }
}
