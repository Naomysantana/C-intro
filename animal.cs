using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico.src
{
    class Animal
    {
        public Animal(){ }

        string Nome, cor, classificacao;

        public virtual void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} esta falando: {comunicacao}");
        }
    }
}
