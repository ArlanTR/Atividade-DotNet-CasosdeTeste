using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.AtualizarSapato;
using AtividadeDotNet.Bordas.Adapter;

namespace AtividadeDotNet.UseCase
{
    public class AtualizarSapatoUseCase : IAtualizarSapatoUseCase
    {
        private readonly IRepositorioSapatos _repositorioSapatos;
        private readonly IAtualizarSapatoAdapter _adapter;

        public AtualizarSapatoUseCase(IRepositorioSapatos repositorioSapatos, IAtualizarSapatoAdapter adapter)
        {
            _repositorioSapatos = repositorioSapatos;
            _adapter = adapter;
        }

        public AtualizarSapatoResponse Executar(AtualizarSapatoRequest request)
        {
            var response = new AtualizarSapatoResponse();
            try
            {
                var sapatoAtualizar = _adapter.converterResquesteParaSapato(request);
                _repositorioSapatos.AtualizarSapato(sapatoAtualizar);
                response.msg = "Sapato atualizado com sucesso!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Atualizar Sapato!";
                return response;
            }

        }
    }
}
