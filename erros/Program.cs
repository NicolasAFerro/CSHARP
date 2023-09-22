using System; 

namespace Erros{ 

  class Program{ 

    static void Main(string[] args){ 
      Console.Clear(); 
      //os erros são trataods como EXCEPTION 
      //algo que não estava previsto para acontecer; 
      //exception para a execução do programa; 


      var arr =  new int[3]; 
      
      // BASE DE TRATAMENTO DE ERROS É TRY/CATCH;
      // faça em blocos;
      try{  
        /* for(int index =0; index<10; index++){
        //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array. 
        Console.WriteLine(arr[index]);
        } */
        Cadastrar("");

      }
      catch(IndexOutOfRangeException ex){ 
        // mais especifico do que o EXCEPTION abaixo, mais direcionado a correção; 
         Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message); 
        Console.WriteLine("não encontrei o indice da lista");
        //sempre tratar do mais especifico para o mais genérico;
      }
       catch(ArgumentException ex){ 
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("falha no texto");
      } 
       catch(MinhaException ex){ 
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.QuandoAconteceu);
        Console.WriteLine("custom");
      }
      catch(Exception ex){ 
        // essa ^declaração como argumento, tem os detalhes da mensagem de erro que aconteceu;

        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("ops, algo deu errado");
      }
      // sempre tem que acontecer 
      finally
      { // tudo que colocar aqui vai ser executado, independente de dar erro ou não;
        Console.WriteLine("Chegou ao fim");
        // talvez um código para fechar o arquivo;
        // conexão com o banco de dados, fecha;
      }
      

      // durante a execução pode dar varios tipos de exeception
      //devido a isso, posso ter vário CATCH 

    }

    static void Cadastrar(string texto){ 
      if(string.IsNullOrEmpty(texto)){ 
  
        //throw new Exception("o texto não pode ser nulo ou vazio");
        //throw new ArgumentNullException("TEXTO NÃO PODE SER NULO OU VAZIO AAAAAA"); 
        throw new MinhaException(DateTime.Now);
      }
    }

    // fazer uma herança da minha exception
    // basicamente criando uma tratativa de erro personalizada minha;

    public class MinhaException : Exception
    { 
    // a função abaixo recebe a variavel date do tipo DateTime;
    // e atribui á "variavel"/"atributo"? QuandoAconteceu 
      
      // isso aqui é um método construtor
      public MinhaException(DateTime date){ 
        QuandoAconteceu=date;
      }
      // atributos/propriedade
      public DateTime QuandoAconteceu{get;set;}
      
    }
    
  }
}