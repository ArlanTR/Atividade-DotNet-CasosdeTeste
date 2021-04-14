using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.RemoverSapato;

namespace AtividadeDotNet.UseCase
{
    public class RemoverSapatoUseCase : IRemoverSapatoUseCase
    {
        private readonly IRepositorioSapatos _repositorioSapatos;
        public RemoverSapatoUseCase(IRepositorioSapatos repositorioSapatos)
        {
            _repositorioSapatos = repositorioSapatos;
        }

        public RemoverSapatoResponse Executar(int request)
        {
            var response = new RemoverSapatoResponse();
            try
            {
                _repositorioSapatos.RemoverSapato(request);
                response.msg = "Sucesso ao Remover sapato!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao remover sapato!";
                return response;
            }
        }
    }
}
