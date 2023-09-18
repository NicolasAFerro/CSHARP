using System; 

namespace EstudoComparacao{ 
  class Program{ 
    static void Main(string[] args ){  
      // 2 métodos 
      var texto = "testando"; 

      // strcmp em C
      Console.WriteLine(texto.CompareTo("testando"));
      
      
      //pode comparar um string totalmente igual
      // ou se ela contem um pedaço;
      // retorna um BOOL;
      Console.WriteLine(texto.Contains("teste"));
      // para ignora o case sensitive 
      Console.WriteLine(texto.Contains("teste",StringComparison.OrdinalIgnoreCase));
      
    }
  }
}