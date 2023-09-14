// See https://aka.ms/new-console-template for more information


using System; 

namespace meuApp{ 
  class Program { // começar com letra maiuscula

    static void Main (string[] args) { 
      // nome do tipo de struct 

      Product mouse= new Product(1, "mouse", 25.56, EproductType.Product);
      var manutencaoEletrica = new Product(2, "manutencao residencial", 500, EproductType.Service);


      Console.WriteLine(mouse.Id); 
      Console.WriteLine(mouse.Name); 
      Console.WriteLine(mouse.Price);  
      Console.WriteLine(mouse.Type); 
    }

  }; 
  //tipo de dado estruturado, estamos criando nosso próprio tipo de dado value type;
  // tem que estar fora de class e fora do main, 
  //competem com class 
  // value type; 
  struct Product{  
    //método construtor, com o mesmo nome da struct para atribuir nos atributos;

    //SÓ UMA FUNÇÃO PARA ENTRAR OS PARAMETROS 
    public Product(int id, string name, double price, EproductType type){ 
      // os parametros de entrada da função em minusculo
      Id=id; 
      Name=name;
      Price=price;
      Type=type;
    };
    //atributos, sempre colocar em maiusculo, 
    public int Id; 
    public string Name; 
    public double Price; 

    public EproductType Type;

    // rotina 
    public double PriceInDolar(double dolar){ 
      return Price*dolar;
    }

  };
  // enumerador para pequenas lista. Tipo estado civil, só entra inteiro
  enum EproductType{ 
    Product=1,
    Service=2;
  };
}



