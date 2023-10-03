
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Security.AccessControl;
using System;
using explorando.Models;  

using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using System.Globalization;
using System.Collections;

namespace Program{ 
  public class meuApp{  
    static void Main(string[] args){   
      Console.Clear();

      //++++Filas-Queue++++
      //queue é uma classe e new está instanciando um novo objeto nela 
      Queue<int> fila = new Queue<int>(); 

      fila.Enqueue(2);
      fila.Enqueue(4); 
      fila.Enqueue(6); 
      fila.Enqueue(8); 
      foreach(int item in fila){ 
        Console.WriteLine(item);
      }
      // sempre vai remover o primeiro elemento da fila;
      Console.WriteLine($"removendo o elemento: {fila.Dequeue()}");  
      fila.Enqueue(0); 
        foreach(int item in fila){ 
        Console.WriteLine(item);
      }


       //++throw+++ 
      //new Excecao().Metodo1();


   



    /*   //+++Leitura de um arquivo+++ 
      //quando vou ler um arquivo, cada linha pode ser retornada como uma string 
      try{                // colocar aqui que vai aparecer as possiveis exceptionsNos métodos
        string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");
        foreach (string linha in linhas){ 
          Console.WriteLine(linha);
        } 
      }catch(DirectoryNotFoundException ex){ // ex é uma variavel //Exception é genérica; 
        Console.WriteLine($"caminho da pasta não encontrado {ex.Message}");// vai pegar a mensagem de erro;

      }
      catch(FileNotFoundException ex){ // ex é uma variavel //Exception é genérica; 
        Console.WriteLine($"arquivo não encontrado {ex.Message}");// vai pegar a mensagem de erro;

      }
      catch(Exception ex){ // ex é uma variavel //Exception é genérica; 
        Console.WriteLine($"ocorreu uma exceção {ex.Message}");// vai pegar a mensagem de erro;

      }finally{ // independente de ter acontecido uma exception ou não
                // tipo fechar a conexão com o banco;
        Console.WriteLine("chegou");
      }
      // exception vai cortar o fluxo, não sabe mais o que fazer
      //try catch


 */














     /*  Pessoa p1=new Pessoa("nicolas", "ferro");
      Pessoa p2=new Pessoa(nome: "joão",sobrenome: "Silva");

      Curso cursoIngles= new Curso();
      cursoIngles.Nome="ingles"; 
      cursoIngles.Alunos = new List<Pessoa>();

      cursoIngles.AdicionarAluno(p1); 
      cursoIngles.AdicionarAluno(p2); 
      cursoIngles.ListarAlunos();


      //++++MOEDAS++++ 
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
      decimal valor = 82.4M; 
      Console.WriteLine($"{valor:C}");//c de Currency
      Console.WriteLine($"{valor:P}");

      //+++Formatação tipo DateTime+++ 
      DateTime data= DateTime.Now;
      Console.WriteLine(data.ToString("dd/mm/yyyy HH:mm"));
      Console.WriteLine(data.ToShortTimeString()); // apenas horas
      Console.WriteLine(data.ToShortDateString()); // apenas data

      string dataString = "2022-04-17 10:05";
      DateTime novadata = DateTime.Parse(dataString);
      DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm",// Se colocar mm já da errado
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None, 
                                out DateTime data1);
      Console.WriteLine (data1);
 */


















      // criei o tipo de dado pessoa; 
      // com isso ela herda os atributos da classe pessoa;

      // instanciar um obj com letra maiscula. Estava dando erro pessoa p1
      /* Pessoa p1= new Pessoa(); 
      p1.Idade=20;
      p1.Nome= "nicolas";
      p1.Sobrenome="ferro";
      p1.Apresentar(); */

    }


  }

}

