using mercanciaBarco.objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace mercanciaBarco.tools
{
    public static class useFiles
    {
        public static void createObjects()
        {
            string[] objects;
            bool val = true;//valida para evitar cabeceras de archivos txt

            objects = System.IO.File.ReadAllLines("Camiones.txt");//Lee archivos, almacenado en ...\mercanciaBarco\mercanciaBarco\bin\Debug\netcoreapp3.1
            foreach (string line in objects)
            {
                //evita guardar cabecera en objetos
                if (val)
                {
                    val = false;
                }
                else
                {
                    //crea objetos
                    Camion cm = new Camion();
                    //divide cada linea de ID, peso y volumen
                    string[] ln = line.Split(';');
                    //asigna
                    cm._id = Convert.ToInt16(ln[0]);
                    cm._volumen = Convert.ToDouble(ln[1]);
                    cm._peso = Convert.ToDouble(ln[2]);
                    //agrega a listado principal
                    Program.camiones.Add(cm);
                }
            }
            val = true;

            objects = System.IO.File.ReadAllLines("Paquetes.txt");
            foreach (string line in objects)
            {
                if (val)
                {
                    val = false;
                }
                else
                {
                    Paquete pq = new Paquete();
                    string[] ln = line.Split(';');
                    pq._id = Convert.ToInt32(ln[0]);
                    pq._volumen = Convert.ToDouble(ln[1]);
                    pq._peso = Convert.ToDouble(ln[2]);

                    Program.paquetes.Add(pq);
                }
            }
        }



    }
}
