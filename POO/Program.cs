using System.Reflection;
using POO.Models; 


namespace POO{ 
  class Program{ 
    static void Main(string[] args){ 
      Console.Clear();

    //###CLASSE ABSTRATA 
    Conta c = new Corrente();
    c.Creditar(500);
    c.ExibirSaldo();










     /*  ///###HERANÇA
      Aluno a1 = new Aluno(); 
      a1.Nome="maria";
      a1.Idade=13; 
      a1.Nota=5.6M;
      a1.Apresentar();
    
      ///###POLIMORFISMO 
      Professor p1= new Professor();
      p1.Nome="pedro";
      p1.Idade=35; 
      p1.Salario=1000M;
      p1.Apresentar(); */
      


      //###CONCEITO DE PRIVADO###
     /*  ContaCorrente c1 = new ContaCorrente(123,1000);
      c1.ExibirSaldo(); 
      c1.Sacar(500); 
      c1.ExibirSaldo(); */
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

