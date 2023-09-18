using System; 

namespace iguais{ 

  class Iguais{ 
    static void Main(string [] args){ 

      // existe em diversos outros objeto no .net; 

      var teste =33; 
      // TEM QUE COMPARAR O MESMO TIPO, INT COM INT, DOUBLE COM DOUBLE;
      teste.Equals();
      var texto = "este texto é um texto"; 
      Console.WriteLine(texto.Equals("este"));



    }
  }
}