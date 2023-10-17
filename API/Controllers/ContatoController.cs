using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;// não esquecer de fazer esse import

//inserir dados da tabela Contatos
namespace API.Controllers
{
    [ApiController] 
    [Route("[controller]")]
    public class ContatoController:ControllerBase
    {
        // construtor:
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context){ 
            _context=context;
        }

        [HttpPost]
        public IActionResult Create(Contatos contato){ 
            _context.Add(contato);
            _context.SaveChanges(); 
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorID(int id){ 
            var contato = _context.Contatos.Find(id);//.contatos é o nosso dbset
            if (contato == null)
                return NotFound();
            return Ok(contato);
        }
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome){ 
            var contatos = _context.Contatos.Where(x=>x.Nome.Contains(nome)); 
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar (int id, Contatos contato){ 
            var contatoBanco = _context.Contatos.Find(id);
            if(contato== null)
                return NotFound();
            contatoBanco.Nome=contato.Nome; 
            contatoBanco.Telefone=  contato.Telefone; 
            contatoBanco.Ativo=contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);

        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id){ 
            var contatoBanco = _context.Contatos.Find(id);
            if(contatoBanco== null)
                return NotFound();
            _context.Contatos.Remove(contatoBanco); 
            _context.SaveChanges();
            return NoContent(); 
        }
        
    }
}