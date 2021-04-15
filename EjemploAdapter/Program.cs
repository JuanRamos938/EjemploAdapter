using System;

namespace EjemploAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro.Encender());
            Console.WriteLine(carro.Conducir());
            Console.WriteLine(carro.Apagar() + "\n");
            Console.ReadKey();

            Moto moto = new Moto();
            Console.WriteLine(moto.Encender());
            Console.WriteLine(moto.Conducir());
            Console.WriteLine(moto.Apagar() + "\n");
            Console.ReadKey();


            VehiculoAdapater televisor = new VehiculoAdapater();
            Console.WriteLine(televisor.Encender());
            Console.WriteLine(televisor.Conducir());
            Console.WriteLine(televisor.Apagar());
            Console.ReadKey();
        }
    }
}
