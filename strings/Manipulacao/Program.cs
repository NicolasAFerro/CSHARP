using System; 

namespace manipulacao{ 
  class Program{ 

    static void Main(string [] args){ 
      var texto =  "Este texto é um texto"; 
      Console.WriteLine(texto.Replace("Este", "Isto")); 

      var divisao = texto.Split(" ");
      for(int i=0; i<4; i++)
        Console.WriteLine(divisao[i]);
      
      // este metodo substring é a primeira posição e conta essa primeira posição que ele ira deslocar; 
      var resultado = texto.Substring(5,5);
      Console.WriteLine(resultado); 
      //var resultado1 = texto.Substring(5, texto.LastIndexOf("o"));
      //Console.WriteLine(resultado1);

    }
  }

}