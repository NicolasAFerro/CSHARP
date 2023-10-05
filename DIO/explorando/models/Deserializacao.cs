using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;// DIRETIVA PARA CONVERSÃO DO JSON

namespace explorando.Models
{
    public class Deserializacao
    {
        public int Id{get;set;}
        [JsonProperty("nome_produto")]// colocar para converter o nome do json para o seu logo abaixo
        public string Produto{get;set;} 
        public decimal Preco{get;set;}
        public DateTime DataVenda{get;set;}
    }
}