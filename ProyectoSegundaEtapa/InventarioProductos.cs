using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_u_y_proyecto_xd
{
    class InventarioProductos
    {
        public InventarioProductos()
        {

        }

        public void Inventario()
        {
            int seleccion = 0;
            do
            {
                try
                {
                    seleccion = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    seleccion = 0;
                }
            } while (seleccion != 1 && seleccion != 2 && seleccion != 3);

            Productos productos = new Productos();

            switch (seleccion)
            {
                case 1:
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE CELULARES Y PRECIOS
                    productos.Celulares();
                    break;

                case 2:
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE CAMARAS Y PRECIOS
                    productos.Camaras();
                    break;
                case 3:
                    //CREACIÓN DE LA LISTA CON LOS MODELOS DE TELEVISORES Y PRECIOS
                    productos.Televisores();
                    break;

            }
        }
    }
}
