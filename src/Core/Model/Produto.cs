using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab.Core.Model
{
    public class Produto
    {
        
        public Guid Id { get; set;}
        public string Codigo {get; set;}
        public Guid CategoriaId {get; set;}
        public string Descricao {get; set;}
        public decimal Preco {get;set;}
        public string UnidadeMedida {get; set;}

    }
}