# TESTES

existem vários tipos de testes=>qualidade;
-Teste cliente!= teste desenvolvedor;
-Teste desenvolvedor: Unitário;

<strong>exemplo<strong>
usuário só cadastrado se o CPF for válido. Caso contrário retorna um erro indicando que está errado;

<strong>vantagem<strong>
-Qualidade;
-se for dar manutenção, mais 5 linhas=>garante que a nova alteração não impacta no resto do sistema;
-menos bugs;
-métodos e classes funcionam;
-previnir problemas futuros;

# frameworks de teste

MSTeste
NUnit
<strong>xUnit<strong>
<strong>como eles são organizados:<strong>
projeto principal e de testes:
o de testes vai ser do tipo xunit e é identico ao principal
sln referencia os dois

# criando testes

-duas pastas, uma do programa e outra dos testes
<strong>dotnet new xunit<strong>
-extensão solution explorer
icone do lado esquerdo inifito;
<Strong>add referencia ao calculadora testes para reconhecer o calculadora<strong>
-botão direito: add reference

-para executar o teste preciso estar dentro de calculadora
