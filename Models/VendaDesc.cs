using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DIO_Pottencial_.NET.Models
{
    public class VendaDesc
    {
        public int Id { get; set; } //MESMO NOME DAS PROPRIEDADES DO JSON

        [JsonProperty("Nome_Produto")] //Atributo que adiciona uma metadata
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
        public decimal? Desconto { get; set; }
    }
}