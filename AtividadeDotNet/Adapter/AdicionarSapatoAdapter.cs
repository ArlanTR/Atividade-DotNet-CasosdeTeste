using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Adapter
{
    public class AdicionarSapatoAdapter : IAdicionarSapatoAdapter
    {
        public Sapato converterResquesteParaSapato(AdicionarSapatoRequest request)
        {
            var novoSapato = new Sapato();
            novoSapato.nome = request.nome;
            novoSapato.marca = request.marca;
            novoSapato.valor = request.valor;
            return novoSapato;
        }
    }
}
