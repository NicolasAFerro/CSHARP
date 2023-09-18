using System; 

namespace interpolacao{ 
  class Program{ 
    static void Main(string[] args ){ 
      var price = 10.2; 
      var texto1 = "o preço do produto é: " + price + "apenas na promoção"; 
      
      var texto2 = "o preço do produto é: + price"; //vai converter 

      // mecanismo de substituição igual em C;
      var texto = string.Format("o preço do produto é {0} apenas na promoção {1}", price, true);
      // csharp segue a ordem que foi inserida;
      var novotexto = string.Format("o preço do produto é {1} apenas na promoção {0}", price, true);
      
      // bem melhor o serviço, tem que colocar o $ na frente
       
       var texto3 = $"o preço do produto é: {price} apenas na produção";

       // o @ permite colocar os caracteres especiais
      var texto4 = $@"o preço do produto é: ${price} apenas na produção";
      Console.WriteLine(texto4);
      Console.WriteLine(novotexto);
    }
  }
}