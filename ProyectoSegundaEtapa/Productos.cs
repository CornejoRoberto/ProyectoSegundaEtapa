using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_u_y_proyecto_xd
{
    class Productos : InventarioProductos
    {
        public Productos()
        {

        }

        public void Celulares()
        {

            Celulares iphone = new Celulares();
            iphone.ModeloCelular = "Iphone 6s";
            iphone.PrecioCelular = 650;
            iphone.CantidadCelular = 30;
            Celulares samsung = new Celulares();
            samsung.ModeloCelular = "Samsung Galaxy Note";
            samsung.PrecioCelular = 800;
            samsung.CantidadCelular = 350;
            Celulares motorola = new Celulares();
            motorola.ModeloCelular = "Motorola G2";
            motorola.PrecioCelular = 260;
            motorola.CantidadCelular = 20;
            Celulares xiaomi = new Celulares();
            xiaomi.ModeloCelular = "Xiaomi Note 10";
            xiaomi.PrecioCelular = 950;
            xiaomi.CantidadCelular = 45;


            List<Celulares> ListaCelulares = new List<Celulares>();
            ListaCelulares.Add(iphone);
            ListaCelulares.Add(samsung);
            ListaCelulares.Add(xiaomi);
            ListaCelulares.Add(motorola);

            //IMPRESION DE LA LISTA DE CELULARES QUE TIENEN HERENCIA DE INVENTARIO
            Console.WriteLine("MODELOS DE CELULARES");
            foreach (Celulares item in ListaCelulares)
                Console.WriteLine (item.ModeloCelular + "\n" + "Con un valor de:" + item.PrecioCelular + "\n" + "Hay un catidad de:" + item.CantidadCelular + " telefonos");
        }


        public void Camaras()
        {
            Camaras nikon = new Camaras();
            nikon.ModeloCamara = "Nikon D3500";
            nikon.PrecioCamara = 840;
            nikon.CantidadCamara = 40;
            Camaras canon = new Camaras();
            canon.ModeloCamara = "Canon M50";
            canon.PrecioCamara = 950;
            canon.CantidadCamara = 30;

            List<Camaras> ListaCamaras = new List<Camaras>();
            ListaCamaras.Add(nikon);
            ListaCamaras.Add(canon);

            Console.WriteLine("MODELOS DE CAMARAS");
            foreach (Camaras item in ListaCamaras)
                Console.WriteLine (item.ModeloCamara + "\n" + "Con un valor de:" + item.PrecioCamara + "\n" + "Hay un catidad de:" + item.CantidadCamara + " camaras");
        }

        public void Televisores()
        {
            Televisores lg = new Televisores();
            lg.ModeloTelevisores = "LG OLED Z1";
            lg.PrecioTelevisores = 965;
            lg.CantidadTelevisores = 65;
            Televisores panasonic = new Televisores();
            panasonic.ModeloTelevisores = "Panasonic Tx-58Gx700E";
            panasonic.PrecioTelevisores = 890;
            panasonic.CantidadTelevisores = 80;
            Televisores tcl = new Televisores();
            tcl.ModeloTelevisores = "TCL 42S6500";
            tcl.PrecioTelevisores = 599;
            tcl.CantidadTelevisores = 78;
            List<Televisores> ListaTelevisores = new List<Televisores>();
            ListaTelevisores.Add(lg);
            ListaTelevisores.Add(panasonic);
            ListaTelevisores.Add(tcl);
            Console.WriteLine("MODELOS DE TELEVISORES");
            foreach (Televisores item in ListaTelevisores)
                Console.WriteLine (item.ModeloTelevisores + "\n" + "Con un valor de:" + item.PrecioTelevisores + "\n" + "Hay un catidad de:" + item.CantidadTelevisores + " televisores");
        }

    }
}
