using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAdapter
{
    class Carro:Vehiculo
    {
        public override string Encender()
        {
            return "¡Carro Encendido!";
        }

        public override string Conducir()
        {
            return "Conduciendo carro";
        }

        public override string Apagar()
        {
            return "Carro Apagado";
        }


    }
}
