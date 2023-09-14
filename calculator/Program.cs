using System;
using System.Collections;
using System.Diagnostics;

namespace Calculator{// USAR UM POR PASTA, NOME DO ARQUIVO, mais organização 
  class Program { // começas letras maiusculas; 
    static void Main(string[] args){ 
     Menu();
    }
    static void Menu(){ 
      
      Console.Clear(); 
      Console.WriteLine("escolha a operação: "); 
      Console.WriteLine("1-Soma "); 
      Console.WriteLine("2-Subtração "); 
      Console.WriteLine("3-Divisão "); 
      Console.WriteLine("4-Multiplicação "); 
      Console.WriteLine("5Sair");

      Console.WriteLine("----------");  
      Console.WriteLine("selecione uma opção: ");
      short res = short.Parse(Console.ReadLine());
      switch(res){ 
        case 1: Soma(); break;
        case 2: Subtracao(); break; 
        case 3: Divisao(); break; 
        case 4: Multiplicacao();break; 
        case 5: System.Environment.Exit(0);break;
        default:Menu(); break;
      };
      


    }
    static void Soma(){ 
      Console.Clear(); // Console,WriteLine,ReadLine; tem que ser tudo com letra maiscula
      Console.WriteLine("primeiro valor: ");// \n 
      float valor1 = float.Parse(Console.ReadLine());  // vai retornar uma string o readLine; 
      // o TIPO.PARSE converte qualquer string para o tipo que declarei;
      
      Console.WriteLine("Segundo valor: "); 
      float valor2 = float.Parse(Console.ReadLine());
      float resultado = valor1 + valor2;

      // Console.WriteLine(valor1); 
      // Console.WriteLine(valor2);
      Console.WriteLine("resultado: " + resultado);
      Console.ReadKey();// não para, armazena o proximo digito;
      Menu();

    }
    static void Subtracao(){ 
      Console.Clear(); 
      Console.WriteLine("primeiro valor: "); 
      float valor1=float.Parse(Console.ReadLine()); 
      Console.WriteLine("segundo valor: "); 
      float valor2=float.Parse(Console.ReadLine());
      float resultado;
      if(valor1<0 && valor2>0)
        resultado = valor1+valor2; 
      else 
        if(valor1>0 && valor2<0) 
          resultado = valor2+valor1;
        else 
          resultado = valor1-valor2;
      
      Console.WriteLine("resultado: " + resultado); 
      Console.ReadKey();
      Menu();
    }
    static void Divisao(){ 
      Console.Clear(); 
      Console.WriteLine("primeiro valor: "); 
      float valor1=float.Parse(Console.ReadLine()); 
      Console.WriteLine("segundo valor: "); 
      float valor2 = float.Parse(Console.ReadLine()); 
      float resultado = valor1 / valor2;
      Console.WriteLine("resultado: "+ resultado); 
      Console.ReadKey();
      Menu();


    }
    static void Multiplicacao(){
      Console.Clear();
      Console.WriteLine("primeiro valor: "); 
      float valor1= float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float valor2 = float.Parse(Console.ReadLine()); 
      float resultado = valor1 * valor2; 
      Console.WriteLine("resultado: "+  resultado);  
      Console.ReadKey();
      Menu();

    }


  };



}