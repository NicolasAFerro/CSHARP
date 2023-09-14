using System; 
using System.IO;// diretiva para usar o streamWriter

namespace textEditor{ 
  class Program{ 
    static void Main(string[] args){ 
      Console.WriteLine("teste"); 
      Menu();
    }
    static void Menu(){ 
      Console.Clear(); 
      Console.WriteLine("o que deseja fazer: "); 
      Console.WriteLine("1 - abrir arquivo"); 
      Console.WriteLine("2 - criar arquivo"); 
      Console.WriteLine("0 - sair"); 
      short option = short.Parse(Console.ReadLine());
      switch(option){ 
        case 0: System.Environment.Exit(0); 
          break;
        case 1:  Abrir(); 
          break; 
        case 2: Editar(); 
          break; 
        default: Menu(); 
          break;


      }
    }
    static void Abrir(){ 
      Console.Clear(); 
      Console.WriteLine("qual o caminho de arquivo: "); 
      string path = Console.ReadLine(); 

      // SEMPRE QUE VAI LER OU SALVAR UM ARQUIVO TEM QUE USAR O USING
      using(var file = new StreamReader(path)){ 
          string text = file.ReadToEnd(); // ler arquivo até o final
          Console.WriteLine(text);
      }
      Console.WriteLine(""); 
      Console.ReadLine(); 
      Menu();
    }
    static void Editar(){ 
      Console.Clear(); 
      Console.WriteLine("Digite seu texto abaixo: "); 
      Console.WriteLine("(ESC) para sair:");
      Console.WriteLine("-----------------------"); 
      string text=""; // aqui vai ter o \0 ou \n;
      do{ 
        text += Console.ReadLine();// apenas isso não vai ter quebra de linha; 
        text += Environment.NewLine;

      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);

    
      Salvar(text);


    }
    static void Salvar(string text){
      Console.Clear(); 
      Console.WriteLine("qual caminho para salvar o arquivo: "); 
      var path= Console.ReadLine(); 

      ///como abrir e fechar arquivos; 
      // using já abre e fecha arquivos sem correr o risco de deixar o arquivo aberto; 
      using (var file = new StreamWriter(path))/*sempre vai pedir um caminho*/ 
      {  //diretiva de fluxo de escrita StreamWriter;
        file.Write(text);

      }
      // usar $ para interpolação de string, como se fosse um %s
      Console.WriteLine($"arquivo{path} salvo com sucesso");
      // na execução, na hoar de salvar o arquivo também está pedindo para salvar 
      // o nome. ..... \teste.txt
      Console.ReadLine();
      Menu();


    }
  }

  
}