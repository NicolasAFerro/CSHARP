using System;
using System.Text.RegularExpressions;

namespace EditorHTML{ 
  public class Viewer{ 
    public static void Show(string text){ 
      Console.Clear(); 
      Console.BackgroundColor= ConsoleColor.White; 
      Console.ForegroundColor =  ConsoleColor.Black;
      Console.Clear(); 
      Console.WriteLine("modo visualização"); 
      Console.WriteLine("--------------"); 
      Replace(text) ; 
      Console.WriteLine("--------------");  
      Console.ReadKey(); 
      Menu.Show();
      
    }

    public static void Replace(string text){ 
      // uma string que substitui uma outra de n formas
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      Console.WriteLine(strong);
    }
  }
}