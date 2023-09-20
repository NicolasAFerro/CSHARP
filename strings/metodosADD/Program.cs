using System; 

namespace Metodos{ 
  class Adicionais{ 
    static void Main(string [] args){ 
      // to lower 
      var texto = "Este texto é um texto"; 
      Console.WriteLine(texto.ToLower()); 
      Console.WriteLine(texto.ToUpper()); 

      Console.WriteLine(texto.Insert(5,"aqui"));

      Console.WriteLine(texto.Remove(5,5)); 
      Console.WriteLine(texto.Length);
    }
  }
}