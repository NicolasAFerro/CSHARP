using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{ 
    [ApiController] 
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {           //usuaria/obterDataHoraAtual
        [HttpGet("ObterDataHoraAtual")]//a requisição http que chama uma função"obterDataHora"
        /* Não precisa ser o mesmo nome do método e do http */
        public IActionResult ObterDataHora(){ 
            var obj = new{ 
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);

        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome){ 
            var mensagem = $"olá{nome}, seja bem vindo"; 
            return Ok( mensagem);
        }
        
    }
}