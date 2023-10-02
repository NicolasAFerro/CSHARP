using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace explorando.models{ 
  public class Curso{ 

    public string Nome { get; set; }
    // propriedade do tipo coleção; é uma lista de pessoas que representam meus alunos;
    public List<Pessoa> Alunos { get; set; }

    //assinatura de um método; é uma função.Void não retorna, mas pode igual C;
    //aluno: nome da variavel que representa pessoa; Pessoa é tipo de dado
    public void AdicionarAluno(Pessoa aluno){ 
      Alunos.Add(aluno);
    }

    // método com retorno
    public int ContarAlunos(){ 
      int quantidade=Alunos.Count;
      return quantidade;
    }

    public bool RemoverAluno(Pessoa Aluno){ 
      return Alunos.Remove(Aluno);
    } 

    public void ListarAlunos(){ 
      Console.WriteLine($"alunos do curso de: {Nome}");
      foreach(Pessoa aluno in Alunos){ 
        Console.WriteLine(aluno.NomeCompleto);
      }
    }

  }
}