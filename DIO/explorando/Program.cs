
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
//using Internal;
//using Internal;
//using Internal;
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

namespace Program{ 
  public class meuApp{  
    static void Main(string[] args){   
      //Console.Clear();
      Pessoa p1=new Pessoa("nicolas", "ferro");
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

