using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.DTO.RetornarSapatoPorId
{
    public class RetornarSapatoPorIDResponse
    {
        public string msg { get; set; }
        public Sapato sapato { get; set; }
    }
}
