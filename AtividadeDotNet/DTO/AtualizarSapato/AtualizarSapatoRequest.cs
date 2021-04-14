using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.DTO.AtualizarSapato
{
    public class AtualizarSapatoRequest
    {
        public int id { get; set; }
        public string nome { get; set; }

        public string marca { get; set; }

        public int valor { get; set; }
    }
}
