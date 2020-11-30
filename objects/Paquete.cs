using System;
using System.Collections.Generic;
using System.Text;

namespace mercanciaBarco.objects
{
    public class Paquete : Herencia
    {
        private int id;
        private bool inTruck;

        public Paquete()
        {
            this._inTruck = false;
        }

        public int _id { get => id; set => id = value; }
        public bool _inTruck { get => inTruck; set => inTruck = value; }
    }
}
