using System;
using System.Text;

namespace EditorHTML{ 

  public static class Editor{ 
    public static void Show(){ 
      Console.Clear(); 
      Console.BackgroundColor= ConsoleColor.White; 
      Console.ForegroundColor =  ConsoleColor.Black;
      Console.Clear(); 
      Console.WriteLine("modo editor"); 
      Console.WriteLine("--------------"); 
      Start();

    }
    public static void Start(){ 
      // string builder quando os textos tem muitas linhas; 
      var file = new StringBuilder();
      do{ 
        file.Append(Console.ReadLine()); 
        file.Append(Environment.NewLine);

      }while(Console.ReadKey().Key != ConsoleKey.Escape); 
      Console.WriteLine("-------------");
      Console.WriteLine(" salvar o arquivo?"); 
      Viewer.Show(file.ToString());
    }
  }
}