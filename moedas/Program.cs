using System;
using System.Globalization;

namespace Moedas{ 
  class Program{ 
    static void Main(string[] args){ 
      Console.Clear(); 
      Console.WriteLine("MOEDAS"); 

      // usar o decimal para trabalhar com valores, por conta de precisão
      // se precisar de uma maior ai usa outro tipo de dado.
      decimal valor = 10.25m;
      Console.WriteLine(valor);

      // formatação DE CULTURA
     
      Console.WriteLine(valor.ToString(
        CultureInfo.CreateSpecificCulture("en-US"))); 
      // formatação formato, sem tanta liberdade
      // "C" coloca cifrão, Euro R$
      //"G"; 
      //"F"; 
      // "N" 
      // P=PORCENTAGEM;
      Console.WriteLine(valor.ToString(
        "C",
        CultureInfo.CreateSpecificCulture("pt-BR"))); 


      // arredondar para cima e para baixo 
      Console.WriteLine(Math.Round(valor));// pega só a parte inteira
      Console.WriteLine(Math.Ceiling(valor));
      Console.WriteLine(Math.Floor(valor));


    }
  }
}
