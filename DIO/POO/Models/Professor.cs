//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"meu nome é  professor {Nome}, tenho {Idade} anos e meu salario é{Salario}");
        }
    }
}