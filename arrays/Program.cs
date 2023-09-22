using System; 

namespace Arrays{ 
  class Program{ 

    static void Main(string [] args){  
      Console.Clear();

      //var meuArray = new int[5]; 
      int[] meuArray = new int [5]{12,13,14,15,16};
      meuArray[0]= 20;

      Console.WriteLine(meuArray[0]);
      Console.WriteLine(meuArray); 
      /* var meuArray = new bool/string/char/ [5]{12,13,14,15,16};
     */

    //ARRAY É REFERENCE TYPE, SEGURA O ENDEREÇO, MUDA TUDO; 
    // PROPRIEDADES. .CLONE copia tudo e não altera no segundo se alterar o primeiro;
     for(int i=0; i<5;i++){ 
      Console.WriteLine(meuArray[i]);
     }
     Console.WriteLine("----------------");
     foreach(var item in meuArray){ 
      Console.WriteLine(item); 

     }
     Console.WriteLine("----------------");

      


    }

  }
}