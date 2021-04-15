using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAdapter
{
    class VehiculoAdapater : Vehiculo
    {
        private Televisor Tv = new Televisor();

        public override string Encender()
        {
            return Tv.EncenderTv();
        }

        public override string Conducir()
        {
            return Tv.VerTv();
        }

        public override string Apagar()
        {
            return Tv.ApagarTv();
        }



    }
}
