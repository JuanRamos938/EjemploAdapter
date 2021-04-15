using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAdapter
{
    class Moto : Vehiculo
    {
        public override string Encender()
        {
            return "¡Moto Encendida!";
        }

        public override string Conducir()
        {
            return "Conduciendo moto";
        }

        public override string Apagar()
        {
            return "Moto Apagada";
        }
    }
}
