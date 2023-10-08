using Internal;
using System.Dynamic;
using System.ComponentModel;
using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      //int testesPassados = ConvertTo.Int32(Console.ReadLine());
      int testesPassados = Convert.ToInt32(Console.ReadLine());

      // Solicita ao usuário a entrada para o número total de testes
      int totalTestes = Convert.ToInt32(Console.ReadLine());

      // TODO: Calcule a taxa de sucesso e armazená-la na variável taxaSucesso:
      int taxaSucesso = (testesPassados / totalTestes) * 100;
      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso}%");
    }
  }
}