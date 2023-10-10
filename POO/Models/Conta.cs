using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{//#CLASSE ABSTRATA, não pode ser instanciada, apenas como modelo para ser herdada
    public abstract class Conta
    {
        protected decimal Saldo;
        //^PROTEGIDO de alterações externas, com exceção das suas classes filhas    
        //^ private mais permissivo

        // MÉTODO ABSTRATO - é obrigado a usar um polimorfismo, por exemplo: 
        // conta corrente e conta poupança- vai mudar este método
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo(){ 
            Console.WriteLine($"o seu saldo é: {Saldo}");
        }
    }
}