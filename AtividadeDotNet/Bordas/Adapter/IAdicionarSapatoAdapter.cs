using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Bordas.Adapter
{
    public interface IAdicionarSapatoAdapter
    {
        public Sapato converterResquesteParaSapato(AdicionarSapatoRequest request);
    }
}
