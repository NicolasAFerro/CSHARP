using System;
using System.Text;


namespace Builder{ 
  class Program{ 
    static void Main(string [] args){ 
      //var texto = "Este texto é um texto"; 

      //string builder 
      // está criando uma terceira variavel para armazenar isso mesmo sem declarar; 
      // texto += "aqui; 

      // o builder constroi mutiplas linhas
      var texto =  new StringBuilder(); // instanciação
      texto.Append("TEXTO AAAAAA");
      texto.Append("aqui"); 
      texto.Append("ouououo");
      Console.Write(texto);


      


    }
  }
}