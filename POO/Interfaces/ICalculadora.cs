using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Interfaces
{//Interfaces é como se fosse uma classe abstrata podendo definir métodos abstratos
// para serem implementados;
    public interface ICalculadora
    {             // ^ Colocar I
        //não tem os acessores public/private
        // só tem a descrição dos métodos: retorno e parametro. função mesmo

        int Somar( int num1, int num2); 
        int Subtrair( int num1, int num2); 
        int Multiplicar( int num1, int num2);  
        int Dividir( int num1, int num2);
       /*  int Dividir( int num1, int num2)
        { se escrever um corpo para o método se torna opcional implementação na class calculadora
            return num1/num2;
        } */
        
    }
}