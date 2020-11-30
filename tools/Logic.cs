using mercanciaBarco.objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace mercanciaBarco.tools
{
    public static class Logic
    {
        public static void loadTruck()
        {
            //Max por cada camion
            double pesoSoportado = 0.0;
            double volSoportado = 0.0;
            
            foreach (var truck in Program.camiones)
            {
                //Se crea lista de paquetes
                List<Paquete> paq = new List<Paquete>();
                foreach (var package in Program.paquetes)
                {
                    //validacion de peso y volumen maximo segun cada camion
                    if (((package._peso + pesoSoportado) <= truck._peso) && ((package._volumen + volSoportado) <= truck._volumen))
                    {
                        //validacion si aun no se ha cargado el paquete en algun camion
                        if (!package._inTruck)
                        {
                            //Incrementa valores max soportados por camion
                            pesoSoportado += package._peso;
                            volSoportado += package._volumen;

                            paq.Add(package);//agrega a lista temporal
                            package._inTruck = true;

                        }
                    }
                    else
                    {
                        //Busca en la lista principal el camion que se recorre y agrega la lista temporal de paquetes
                        Program.camiones.Find(x => x._id == truck._id)._paquetes = paq;
                    }
                }
                //reseteo de variables para cada camion
                pesoSoportado = 0.0;
                volSoportado = 0.0;
                truck._enDespacho = true;
                Console.WriteLine("Camion con ID:"+truck._id+", salio a reparto");
            }
            Console.WriteLine("\n");
        }
    }
}
