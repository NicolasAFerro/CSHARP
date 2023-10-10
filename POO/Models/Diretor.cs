using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Diretor : Professor// 'Diretor': cannot derive from sealed type 'Professor
    {
         public Diretor(string nome): base (nome){ 
        }
        public override void Apresentar(){//'Diretor.Apresentar()': cannot override inherited member 'Professor.Apresentar()' because it is sealed
            //      ^ sobrescreveu a classe apresentar de pessoa
            Console.WriteLine($"Diretor");
        }
    }
}