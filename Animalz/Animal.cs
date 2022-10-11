using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        // Atributos de animal
        private float Peso;
        private int Idade;
        private int Membros;

        //Métodos de animal
        public abstract void locomover();
        public abstract void alimentar();
        public abstract void emitirSom();
    }
}
