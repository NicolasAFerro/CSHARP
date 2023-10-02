using System;
using explorando.models;  
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace Program{ 
  public class meuApp{  
    static void Main(string[] args){   
      Pessoa p1=new Pessoa("nicolas", "ferro");
      Pessoa p2=new Pessoa(nome: "joão",sobrenome: "Silva");

      Curso cursoIngles= new Curso();
      cursoIngles.Nome="ingles"; 
      cursoIngles.Alunos = new List<Pessoa>();

      cursoIngles.AdicionarAluno(p1); 
      cursoIngles.AdicionarAluno(p2); 
      cursoIngles.ListarAlunos();
















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

