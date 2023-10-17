# API

trabalha com requisições http

## Documentação da API

    pois não sabe o que retorna e o que faz(entender os endpoints dela)

<strong>ecommerce<strong>
Empresa de Ecommerce
API ENTREGAS
Empresa de transporte
A empresa de transporte tem que saber que pode entregar
A empresa de Ecommerce tem que saber o prazo de entrega
-via de duas mãos
-status do pedido

# dotnet new webapi

-controllers
-properties
2arquivos json
-weatherforecas(hello world)

## dotnet watch run

toda alteração que fizer na api n vai precisar pausar e rodar novamente;
fica observando os arquivos da sua API
e caso encontre uma alteração, recompila automaticamente

AI VAI PARA O swagger

### teste de API

como se fosse um insominia
API NO DOTNET É SWAGGER(para documentar)
nem toda api tem um swagger

### oq é uma controller

classe com final do nome CONTROLLER
-controller é uma classe que vai agrupar suas requisições http e disponibilizar
endpoints
WeatherForecastController: tudo relacionado a previsão do tempo vai colocar dentro dela
<strong>basicamente um namespace<strong>
usuarioController
produtoController
using Microsoft.AspNetCore.Mvc; <!-- tem que importar -->

namespace API.Controllers
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase <!-- herdar da classe mae -->

# Entender as rotas

# ENTITY FRAMEWORK

ORM (object-relational mapping): facilitar a integração com o banco de dados,
gerando comandos sql de forma automáticas;
c# não sabe "insert"; a não ser que eu passe o comando
DATA LAYER

## CRUD

CREATE READ UPDATE DELETE;
entity vai retornar um objeto do banco de dados;

## PARA INSTALAR O ENTITY:

dotnet tool install --global dotnet-ef
apenas uma vez(não precisa mais executar)-fica a nivel de máquina, e não no .csproj

esse em todo projeto:
pacote do entity> dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
<strong> para conferir se deu certo: API.csproj<strong>

# doing

folder:entities;
class: vai virar uma tabela no db;

#### CADASTRAR A CONEXÃO NO ARQUIVO DE CONFIGURAÇÃO E INICIALIZAR O DB CONTEXT

2 arquivos json
properties>appsettings.Development(só usa para testes/desenvolvimento)
properties> appsettings.json(usa para produção/ implantar em um ambiente real)

appsettings.Development
"ConnectionStrings": {
//outro banco é outro jeito
"ConexaoPadrao": "Server=localhost\\sqlexpress;Initial Catalog=Agenda;Integrated Security=True"} //"ConexaoPadrao": "Server=localhost\\sqlexpress02; Initial Catalog=Agenda; Integrated Security=SSPI;TrustServerCertificate=True"

agora precisamos falar para o context>agendaContext que ele vai usar aquela configuração ali{
program.cs{

#### CONEXÃO COM O BANCO

using API.Context;
using Microsoft.EntityFrameworkCore;
// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")))
}
}

#### migrations

os comandos sql são automáticos, mas os de criação de tabela são manuais
(dizer ao entity que tem alterações no código que precisam ser refletidas no DB)
dotnet-ef migrations add CriacaoTabelaContato
-Cria uma pasta chamada migrations

- nos só criamos a migration, agora temos que aplicar:
  dotnet-ef database update

  //se estiver outro banco ai é outra coisa ^o banco que ele vai trabalhar(nome)
  // ^entity vai fazer para ti iniciar só com a autenticação do windowns(usuario e senha se remoto)

  //outro banco é outro jeito

## criar controler e endpoint de create

-inserir dados na tabela através do entity framework
criar nova controller:new class

### o db está em context e o objetido fica no entities

# dotnet add package Microsoft.EntityFrameworkCore.SqlServer

# dotnet add package Microsoft.EntityFrameworkCore.Design

1° connectionstrings
2° criar entidade: classe da api e ao mesmo tempo uma tabela;
3°Context: agendacontext>herda de db context.
^classe que utilizaremos para ter a conexão com o banco;
4°agenda context tem várias propriedades do tipo dbset<do tipo da entidade>
5°se não estiver ali, não vai ser identificado como tabela;
6°program builder
7°Migration:espelhar as alterações do código no banco de dados;
8° agora tem que aplicar a migration: fazer o comando de atualização : dotnet-ef database update
9° pacotes: dotnet add package Microsoft.EntityFrameworkCore.SqlServer; dotnet add package Microsoft.EntityFrameworkCore.Design// instalar em cada projeto
10° CONTROLLER: Ponto de entrada que disponibilizaremos os métodos;
recebe o = private readonly AgendaContext \_context (permite acessar o db)
11° todos colocar savechanges;

# dotnet-ef migrations add CriacaoTabelaContato

# dotnet-ef database update
