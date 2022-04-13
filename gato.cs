using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico.src
{
     public class Gato : Animal
    {

        public Gato() { }

       public Gato(string nome, string cor, string classificacao) : base(nome, cor, classificacao) { }

        public override void Comunicar(string comunicacao, object nome) => Console.WriteLine($"{nome} esta falando: {comunicacao}");
    }

    public class Animal
    {
        internal readonly string Classificacao;

        public Animal()
        {
        }

        public Animal(string nome, string cor, string classificacao)
        {
        }

        public object Nome { get; internal set; }

        internal void Comunicar(string v)
        {
            throw new NotImplementedException();
        }
    }
}