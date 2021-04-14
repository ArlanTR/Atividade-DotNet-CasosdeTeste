using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.DTO.AtualizarSapato;
using AtividadeDotNet.Entities;
using AtividadeDotNet.Bordas.Adapter;
namespace AtividadeDotNet.Adapter
{
    public class AtualizarSapatoAdapter: IAtualizarSapatoAdapter
    {
        public Sapato converterResquesteParaSapato(AtualizarSapatoRequest request)
        {
            var novoSapato = new Sapato();
            novoSapato.id = request.id;
            novoSapato.nome = request.nome;
            novoSapato.marca = request.marca;
            novoSapato.valor = request.valor;
            return novoSapato;
        }
    }
}
