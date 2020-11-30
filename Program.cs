using System;
using System.Collections.Generic;
using mercanciaBarco.objects;
using mercanciaBarco.tools;

namespace mercanciaBarco
{
    class Program
    {
        //Listas en donde se pasara la info de los txt's
        public static List<Camion> camiones = new List<Camion>();
        public static List<Paquete> paquetes = new List<Paquete>();
        static void Main(string[] args)
        {
            useFiles.createObjects();//pasa la info del txt a objects
            Logic.loadTruck();//Se Destribuye paquetes en los camiones

            double cantPeso = 0;
            double cantVol = 0;
            Console.WriteLine("Paquetes que no se entregaran el dia de hoy:");
            foreach (var paq in paquetes)//recorre paquetes
            {
                if (!paq._inTruck)
                {
                    Console.WriteLine("\t ID paquete:"+ paq._id + " - PESO paquete:" + paq._peso + " - VOLUMEN paquete: " + paq._volumen + " - Paquete cargado en camion: " + paq._inTruck);
                    cantPeso += paq._peso;
                    cantVol += paq._volumen;
                }
            }
            Console.WriteLine("\n");

            foreach (var item in camiones)//recorre camiones
            {
                Console.WriteLine("Carga de camion con ID "+item._id + ":");
                Console.WriteLine("ID paquetes:");
                foreach (var pack in camiones.Find(x => x._id == item._id)._paquetes)//recorre los paquetes encontrados, segun el camion
                {
                    Console.WriteLine("\t paquete ID "+pack._id + ".");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Peso sin transportar:\n"+cantPeso+"\nVolumen sin transportar:\n"+cantVol+"\n");
            Console.WriteLine("----------Gracias por usar nuestros servicios (presione cualquier tecla para salir).-----------");
            Console.ReadKey();
            
        }
    }
}
