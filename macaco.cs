using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico.src
{
     public class Macaco : Animal
    {

        public Macaco() { }

       public Macaco(string nome, string cor, string classificacao) : base(nome, cor, classificacao) { }

       public override void comunicar(string comunicacao, object nome)
       {
           Console.WriteLine($"{nome} esta falando: {comunicacao}");
       }
    }
}