using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Bordas.Adapter;

namespace AtividadeDotNet.UseCase
{
    public class AdicionarSapatoUseCase : IAdicionarSapatoUseCase
    {
        private readonly IRepositorioSapatos _repositorioSapatos;
        private readonly IAdicionarSapatoAdapter _adapter;

        public AdicionarSapatoUseCase(IRepositorioSapatos repositorioSapatos, IAdicionarSapatoAdapter adapter)
        {
            _repositorioSapatos = repositorioSapatos;
            _adapter = adapter;
        }
        public AdicionarSapatoResponse Executar(AdicionarSapatoRequest request)
        {
            var response = new AdicionarSapatoResponse();
            try
            {
                if (request.nome.Length < 1) {
                    response.msg = "Erro ao Adicionar produto Nome invalido";
                    return response;
                }
                var sapatoAdicionar = _adapter.converterResquesteParaSapato(request);
                _repositorioSapatos.Add(sapatoAdicionar);
                response.msg = "Sapato adicionado com sucesso!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Adicionar Sapato!";
                return response;
            }

        }
    }
}
