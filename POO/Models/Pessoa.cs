//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        //CONSTRUTOR POR HERANÇA
        //Nome ser obrigatório smpre que alguem instanciar pessoa, deve ser através do construtor
        // acho melhor deixar assim obrigatório, e não deixar"se eu quiser posso inserir a idade"
        public Pessoa(string nome){ 
            Nome=nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){ 
            //     ^ significa que este método pode ser sobescrito se assim a classe desejar
            Console.WriteLine($"meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}