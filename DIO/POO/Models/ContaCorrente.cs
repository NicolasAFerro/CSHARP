using System.Reflection.Emit;
using System.Data;
//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {   
        public ContaCorrente(int numeroConta, decimal saldoIncial)
        {
            NumeroConta=numeroConta; 
            Saldo=saldoIncial;
        }
        public int NumeroConta { get; set; } 
        private decimal Saldo; // só a minha classe consegue alterar;
        public void Sacar(decimal valor){ 
            if(Saldo>=valor)
                Saldo-=valor;
            else 
                Console.WriteLine("saldo indisponivel");
        }
        public void ExibirSaldo(){ 
            Console.WriteLine(Saldo);
        }
    }
}