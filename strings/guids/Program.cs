using System; 


namespace guids{ 

  class Program{ 
    static void Main(string[] args){ 
      // guids são usadas para id
      //GLOBAL UNIC IDENTIFIER;
      // para gerar valor random; 
      // assim é um tipo de dado;
      var id = Guid.NewGuid();
      id.ToString();
      id = new Guid();// tudo 0000;

    }
  }
}