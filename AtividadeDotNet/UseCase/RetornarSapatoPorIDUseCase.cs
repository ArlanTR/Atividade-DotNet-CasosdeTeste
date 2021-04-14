using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.RetornarSapatoPorId;

namespace AtividadeDotNet.UseCase
{
    public class RetornarSapatoPorIDUseCase : IRetornarSapatoPorIDUseCase
    {
        private readonly IRepositorioSapatos _repositorioSapatos;

        public RetornarSapatoPorIDUseCase(IRepositorioSapatos repositorioSapatos)
        {
            _repositorioSapatos = repositorioSapatos;
        }

        public RetornarSapatoPorIDResponse Executar(int request)
        {
            var response = new RetornarSapatoPorIDResponse();
            try
            {
                response.sapato = _repositorioSapatos.RetornaSapatoPorId(request);
                response.msg = "Sapato encontrado com sucesso!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao encontrar sapato!";
                return response;
            }
        }
    }
}
