using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using POO.Interfaces;


namespace POO.Models
{// polimorfismo em tempo de execução
    public class Calculadora : ICalculadora// faço uma IMPLEMENTAÇÃO(NÃO É HERANÇA) da interface calculador
    {                          // se eu quiser usar essa interface, tenho que implementar os 
        public int Dividir(int num1, int num2)
        {
           return num1/num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1*num2;
        }

        //os métodos dela
        public int Somar(int num1, int num2){ 
            return num1+num2;
        }

        public int Somar(int num1, int num2, int num3){ 
            return num1+num2+num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1-num2;
        }
    }
}