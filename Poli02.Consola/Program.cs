using Poli02.Entidades;
using System;

namespace Poli02.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Perro perro = new Perro();
            Gato gato = new Gato();

            Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(gato.EmitirSonido());

            Animal perro2 = new Perro();
            Animal gato2 = new Gato();

            Console.WriteLine("-------------------");

            Console.WriteLine(perro2.EmitirSonido());
            Console.WriteLine(gato2.EmitirSonido());

            Console.ReadLine();
        }
    }
}
