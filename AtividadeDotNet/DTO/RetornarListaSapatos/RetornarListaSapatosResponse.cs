using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.DTO.RetornarListaSapato
{
    public class RetornarListaSapatosResponse
    {
        public string msg { get; set; }
        public List<Sapato> ListaSapato { get; set;}
    }
}
