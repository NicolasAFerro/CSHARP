using System.Reflection;
using POO.Models; 


namespace POO{ 
  class Program{ 
    static void Main(string[] args){ 
      Console.Clear();
      ContaCorrente c1 = new ContaCorrente(123,1000);
      c1.ExibirSaldo(); 
      c1.Sacar(500); 
      c1.ExibirSaldo();
      //error CS0122: "ContaCorrente.Saldo" é inacessível devido ao seu nível de proteção
      // só altero  saldo atraves do método SACAR;
     /*  //VARIAVEL do tipo pessoa;
      Pessoa p1= new Pessoa(); 
      p1.Nome="joão";
      p1.Idade=20;
      p1.Apresentar();*/
    } 
  }
}

