//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){ 
            //     ^ significa que este método pode ser sobescrito se assim a classe desejar
            Console.WriteLine($"meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}