using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
namespace CalculadoraTestes
{
    public class validacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public validacoesStringTestes(){ 
            _validacoes=new ValidacoesString();
        } 
        [Fact]
        public void DeveContar3caracteresEmOlaRetornar3(){ 
            //Arrange 
            string texto = "olá";
            //act 
            int resultado = _validacoes.ContarCaracteres(texto);
            //assert 
            Assert.Equal(3,resultado);
        }
    }
}