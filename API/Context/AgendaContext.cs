using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;


namespace API.Context
{
    public class AgendaContext : DbContext//estamos herdando os comando, vem do entity
    { 
        // com qual DB ele vai se comunicar? Realizar um método construtor
        public AgendaContext(DbContextOptions<AgendaContext> options):base(options){ 
            //db context que inicia a conexão. Então e
        }
        public DbSet<Contatos> Contatos { get; set; }// referente a entidade(classe no programa e uma tabela no DB) 
                    //^mesma classe que está em entities 
            //está dentro de dbset pois está representando uma classe e uma tabela ENTIDADE 
                            // ^NOME
    }
}