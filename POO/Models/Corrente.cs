using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Corrente : Conta
    {



        // todo método abstrato eu preciso dar um override
        public override void Creditar(decimal valor)
        {
            Saldo+=valor;
        }
    }
}