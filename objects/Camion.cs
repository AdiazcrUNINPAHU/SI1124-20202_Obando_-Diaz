using System;
using System.Collections.Generic;
using System.Text;

namespace mercanciaBarco.objects
{
    public class Camion : Herencia
    {
        private int id;
        private List<Paquete> paquetes;
        private bool enDespacho;

        public Camion()
        {
            this._enDespacho = false;
        }

        public int _id { get => id; set => id = value; }
        public List<Paquete> _paquetes { get => paquetes; set => paquetes = value; }
        public bool _enDespacho { get => enDespacho; set => enDespacho = value; }
    }
}
