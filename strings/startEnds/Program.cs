using System; 

namespace ComecoFim{ 

  class Explorando{ 

    static void Main(string[] args){ 

      // retorna bool
      var texto = "este é um texto teste"; 
      Console.WriteLine(texto.StartsWith("este")); 
      Console.WriteLine(texto.StartsWith("Este"));
      Console.WriteLine(texto.EndsWith("TESTE"));

    }
  }
}
