using System;  
using System.Threading;

namespace stopWatch{ 
  class Program{ 
    static void Main(string[] args){ 
      //start(6); 
      Menu();
    }
    static void Menu(){ 

      Console.Clear();
      Console.WriteLine("S= Segundos => 10s = 10segundos");
      Console.WriteLine("M= Minutos => 1m = 1minuto"); 
      Console.WriteLine("0= Sair"); 
      Console.WriteLine("Quanto tempo deseja contar: "); 
      string data = Console.ReadLine().ToLower();// LEMBRAR DESSAS COISAS DE MAIUSCULO E MINUSCULO
      // esse método substring permite criar uma substring, passando (posição inicial, Deslocamento); 

      char type= char.Parse(data.Substring(data.Length-1, 1));// pegando o ultimo caracter
      int time = int.Parse(data.Substring(0,data.Length-1));// pegando todos menos o ultimo
      int multiplier=1; 
      if(type=='m') 
        multiplier=60;
      if(time==0) 
        System.Environment.Exit(0); 
      PreStart(time * multiplier);// prestar atenção em maisculas e minusculas;

    }

    static void PreStart(int time){ 
      Console.Clear(); 
      Console.WriteLine("Ready..."); 
      Thread.Sleep(1000);
      Console.WriteLine("Set..."); 
      Thread.Sleep(1000); 
      Console.WriteLine("GO..."); 
      Thread.Sleep(2500);

      Start(time);
    }
    static void Start(int time){ 
       
      int currentTime = 0; 
      while(currentTime!=time){ 
        Console.Clear();
        currentTime++; 
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }  
      Console.Clear(); 
      Console.WriteLine("StopWatch Finalizado");
      Thread.Sleep(2000);
      Menu();
    } 
  }
}
