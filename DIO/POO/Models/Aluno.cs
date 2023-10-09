//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa //herdando de pessoa
    {
        public decimal Nota { get; set; }

        public override void Apresentar(){ 
            //   ^ aqui está sobrescrevendo o método apresentar
            // polimorfismo em tempo de excução
            
            Console.WriteLine($"meu nome é aluno {Nome}, tenho {Idade} anos e minha nota é {Nota}");
        }
    }// polimorfismo em tempo de compilar; soma com 2 e 3 argumentos;
}