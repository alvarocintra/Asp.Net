using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula_Asp.Net_01.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; } 
    }
}