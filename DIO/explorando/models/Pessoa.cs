using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

// lembrar de colocar o mesmo nome da pasta e caminhos.
namespace explorando.models{ 

  public class Pessoa{ 
    public Pessoa(){ 

    }// assim ^ eu consigo construi tanto na mão como passando argumentos
    //Por padrão, um construtor fica logo abaixo da classe, é a primeira coisa; 
    public Pessoa(string nome, string sobrenome){ // tem o mesmo nome da sua classe; 
      Nome=nome; 
      Sobrenome=sobrenome;
    }
    

    // construindo uma propriedade
    private int _idade;// isso aqui é um campo
    private string _nome;// POO. Encapsulamento campo que vai armazenar o atributo nome;
    // Private, unico que consegue armazenar /modificar é a propria classe
    // criei uma variavel do tipo nome, que eu atribuiu valores atraves das 
    // propriedade.Com isso estou validando minha classe antes de atribuir um valor a ela;
    public string Nome { 
      // get => _nome.ToUpper() se for simples. BodyExpression
      get{ 
        return _nome.ToUpper();
      }
      set{ //set é =(atribuição)
        if (value==""){ 
          throw new ArgumentException ("nome não pode ser vazio"); 
          // posso fazer um Focus();

        }
        _nome = value;
      }
    }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome}{Sobrenome}";//somente leitura
    
    public int Idade { 
      get => _idade;

      set{ 
        if (value<0){ 
          throw new ArgumentException("idade não pode ser menor que 0");
        }
       _idade= value;
      }
    }// set é =;

    //+++++++++++++++++++++++++++++++++++++++++++++=
    //criar um método 
    // está dentro da classe Pessoa.


    public void Apresentar(){ 
      // aqui get
      Console.WriteLine($"nome:{NomeCompleto}, idade:{Idade}");
    }
    


  }
}