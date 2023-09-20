using System; 



namespace EditorHTML{ 
  public static class Menu{ 
    public static void Show(){ 
      Console.Clear();
     

      // firula; 
      Console.BackgroundColor =  ConsoleColor.Blue; 
      Console.ForegroundColor =  ConsoleColor.Black; 

      DrawScreen();
      WriteOptions();
      var options = short.Parse(Console.ReadLine());
      HandlerMenuOption(options);

    }
    public static void DrawScreen(){ 

      Console.Write("+");
      for(int i=0;i<=30; i++){ 
        Console.Write("-");
      }
      Console.Write("+");// sem \n writeline é com \n;
      Console.Write("\n");
      for(int lines = 0; lines<=10; lines++){ 
        Console.Write("|"); 
        for(int j=0;j<=30;j++) 
          Console.Write(" "); 
        Console.Write("|");
        Console.Write("\n");
      }
      Console.Write("+");
      for(int i=0;i<=30; i++){ 
        Console.Write("-");
      }
      Console.Write("+");
    }

    public static void WriteOptions(){
      //para escrever algo em uma posição especifica da tela 
      Console.SetCursorPosition(3,2);
      Console.WriteLine("editor html"); 
      Console.SetCursorPosition(3,3);
      Console.WriteLine("================="); 
      Console.SetCursorPosition(3,4);
      Console.WriteLine("Selecione uma opção: "); 
      Console.SetCursorPosition(3,6); 
      Console.WriteLine("1-novo arquivo "); 
      Console.SetCursorPosition(3,7); 
      Console.WriteLine("2-abrir arquivo "); 
      Console.SetCursorPosition(3,9); 
      Console.WriteLine("0- sair "); 
      Console.SetCursorPosition(3,10); 
      Console.Write("opção: ");
    }
    public static void HandlerMenuOption(short options){ 
      switch(options){ 
        case 1: Editor.Show(); break; 
        case 2: Console.WriteLine("view"); break;  
        case 0: {
          Console.Clear();
          Environment.Exit(0);
          break; 
        }
        default: Show(); break;


      }
    }
  }
}