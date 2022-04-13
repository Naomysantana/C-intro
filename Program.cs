using System;
using System.Collections.Generic;
using Zoologico.src;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args, IEnumerable<Animal> animais)
        {
            Console.WriteLine("Zoologici");

            List<Animal> animals = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Amélio", "Branco", "felino"),
                    new Cachorro("Cachorro Rodolfo", "marrom", "canídio"),
                    new Macaco("Macaco Chico", "marrom", "Primata")
                }
            );
            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("au au au"); 
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("miau miau");
                }
                else if ( animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("uhuhu");

                }

            }

        }

        private static void NewMethod(Animal animal)
        {
            animal.Comunicar("Au au!");
        }
    }
}
