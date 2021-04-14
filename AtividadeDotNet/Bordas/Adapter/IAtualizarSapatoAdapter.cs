using AtividadeDotNet.DTO.AtualizarSapato;
using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Bordas.Adapter
{
    public interface IAtualizarSapatoAdapter
    {
        public Sapato converterResquesteParaSapato(AtualizarSapatoRequest request);
    }
}
