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
