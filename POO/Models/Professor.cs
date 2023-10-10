//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public /* sealed */ class Professor : Pessoa
    {      //^ estou selando impedindo que essa classe possa ser herdada
            // não pode ter mais filhos

        //Também quebrou a herança, igual Aluno 
        //PROFESSOR TAMBÉM EXIGE NOME, ASSIM COMO PESSOA
        public  Professor(string nome): base (nome){ 
                                    //    ^ estou passando para a classe pai
        }
        public decimal Salario { get; set; }

        public /* sealed */ override void Apresentar(){
            //      ^ sobrescreveu a classe apresentar de pessoa
            Console.WriteLine($"meu nome é  professor {Nome}, tenho {Idade} anos e meu salario é{Salario}");
        }
    }
}

//POLIMORFISMO EM TEMPO DE EXECUÇÃO
/* // class Calcular
    {
        public int Soma(int num1, int num2)
        {
            return (num1 + num2);
        }
       
        public int Soma(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
    } */