using System;
using System.Collections.Generic;
using System.Text;

namespace mercanciaBarco.objects
{
    public class Herencia
    {
        private double volumen;
        private double peso;

        public double _peso { get => peso; set => peso = value; }
        public double _volumen { get => volumen; set => volumen = value; }
    }
}
