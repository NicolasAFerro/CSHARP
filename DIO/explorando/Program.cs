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
using Newtonsoft.Json;//USAR DO PACOTE NUGET

namespace Program{ 
  public class meuApp{  
    static void Main(string[] args){   
      Console.Clear();


  //##DESERIALIZAÇÃO## 
  //estudar o conteudo do arquivo. Ver as propriedades
  string conteudoArquivo = File.ReadAllText("arquivos/vendas.json");
  //como eu tenho um array, tbm tenho que representar um array; 
  List<Deserializacao> listaVendas = JsonConvert.DeserializeObject<List<Deserializacao>>(conteudoArquivo); 
  foreach(Deserializacao venda in listaVendas){ 
    Console.WriteLine($"ID:{venda.Id}; produto:{venda.Produto};" + //fazer com o mesmo nome, pois estava PRODUCT E NÃO ESTAVA LENDO;
                      $"PREÇO: {venda.Preco}; data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
  }








  /* //###SERIALIZAÇÃO### 
  //criar classe vendas
  //using Newtonsoft.Json;//USAR DO PACOTE NUGET
  //elemento tipo de venda; se chama listaVendas; Nova instancia; List<Vendas>() está vazia
   List<Vendas> listaVendas = new List<Vendas>();
  /*  após a execução dessa linha de código, você terá uma variável 
   chamada listaVendas 
   que é uma lista vazia pronta para armazenar objetos do tipo Vendas 
  DateTime dataAtual= DateTime.Now;
  Vendas v1 =new Vendas(1, "caneta", 1.25M, dataAtual);
  Vendas v2 = new Vendas(23, "Saas", 130.45M, dataAtual);
  // aqui eu tenho duas vendas. Como passar todas? 
  //criar uma coleção // array
  listaVendas.Add(v1); 
  listaVendas.Add(v2);

  string serializado =JsonConvert.SerializeObject(v1);// ver documentação;  
  string serializado2 =JsonConvert.SerializeObject(v1, Formatting.Indented); 
  string serializado3 =JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
  File.WriteAllText("Arquivos/vendas.json", serializado3);// criou o arquivo Json em arquivos;
  Console.WriteLine(serializado);
  Console.WriteLine(serializado2); 
   Console.WriteLine(serializado3);
   //codeBeauty/json; verificar se está válido MINIFY XML(tags) */
  //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=

   /*  //++if ternario+++ 
    int num =20;
    bool parOuImpar=false;                  // igual excel
    parOuImpar=num % 2 ==0;                //condicao verdadeira, condição falsa
    Console.WriteLine($"o numero{num} é: " + (parOuImpar ? "par":"impar"));

   /*  if(num%2==0)
      Console.WriteLine("par");
    else 
      Console.WriteLine("impar"); */ 






      /* //++desconstruindo um objeto++ 
      // declarei um método de desconstrução na classe pessoa;

      //aqui em construi
      Pessoa p1= new Pessoa("nicolas","ferro");

      //aqui eu desconstrui;
      // coloca em variaveis separadas; por isso que o printf da certo
      (string nome, string sobrenome)=p1;
      Console.WriteLine($"{nome}+{sobrenome}"); */
















      /* 
      //++TUPLAS++ ACHO MELHOR CRIAR UMA STRUCT OU UMA CLASSE, MUITA GAMBIARRA ISSO AQUI
                                            //tupla é o nome da variavel
      (int id, string nome, string sobrenome,decimal valor) tupla=(24, "nicolas", "ferro",10.5M); 

      //não consegue nomear objeto;
      ValueTuple<int, string, string, decimal> outroExemplo = (24, "nicolas", "ferro",10.5M); 
      var outroExemplo1 = Tuple.Create(24, "nicolas", "ferro",10.5M); 


      Console.WriteLine($"id: {tupla.id}"); 
      Console.WriteLine($"id: {tupla.Item1}");
      Console.WriteLine($"nome: {tupla.nome}"); 
      Console.WriteLine($"sobrenome: {tupla.sobrenome}"); 
      Console.WriteLine($"decimal: {tupla.valor}");


      // bom para fazer retorno de método ou função 
      //nome da classe
      LeituraArquivo arquivo = new LeituraArquivo();
                                              // nome do método
      var(sucesso, Linhas, qtdLinhas) =  arquivo.LerArquivo("arquivos/arquivoLeitura.txt");
      if(sucesso){ 
        Console.WriteLine("quantidade de linahs do arquivo: "+ qtdLinhas);
        foreach( var linhas in Linhas)
        Console.WriteLine(linhas);
      }
      else
        Console.WriteLine("não foi possivel ler o arquivo"); 
      /*  caso por exemplo, me retorne um monte de coisa, mas eu só quero
      duas informações, coloco o _ que ignora
      var(sucesso, Linhas, _) =  arquivo.LerArquivo("arquivos/arquivoLeitura.txt"); */
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

      /* // ++++Dictionary+++
      //minha chave e meu dado são strings
      // garente que cada elemento seja unico
      Dictionary<string, string> estados = new Dictionary<string, string>();
                // o primeiro elemento tem que ser unico;
      estados.Add("SP", "SÃO PAULO");
      estados.Add("BA", "BAHIA"); 
      estados.Add("MG", "MINAS GERAIS");

      foreach(var item in estados)
        Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
      //estados.Add("BA", "AMAZONAS");// CHAVE NUNCA PODE SER DUPLICADA
      Console.WriteLine("+++++++++++++++");
      estados.Remove("BA"); 
      foreach(var item in estados)
        Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
      string chave = "BA";
      if(estados.ContainsKey(chave))
        Console.WriteLine("chave existente");
      else 
        Console.WriteLine("chave inexistente");
      Console.WriteLine($"Acessando elemento:  {estados["MG"]}"); */

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=

    /* //+++Pilhas+++
    Stack<int> pilha = new Stack<int>();
    pilha.Push(4); 
    pilha.Push(6); 
    pilha.Push(8); 
    pilha.Push(10);
    // sempre vai remover o ultimo elemento da pilha LIFO;
    foreach(var item in pilha)
      Console.WriteLine(item);
    Console.WriteLine($"removendo um elemento do topo: {pilha.Pop()}");  
    pilha.Push(23);
    foreach(var item in pilha)
      Console.WriteLine(item); */

      /* //++++Filas-Queue++++
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
      } */
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


      //####EXCEPTION###
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

