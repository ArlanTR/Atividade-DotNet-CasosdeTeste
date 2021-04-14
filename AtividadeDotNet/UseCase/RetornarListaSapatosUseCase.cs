using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.RetornarListaSapato;

namespace AtividadeDotNet.UseCase
{
    public class RetornarListaSapatosUseCase : IRetornarListaSapatosUseCase
    {
        private readonly IRepositorioSapatos _repositorioSapatos;
        public RetornarListaSapatosUseCase(IRepositorioSapatos repositorioSapatos)
        {
            _repositorioSapatos = repositorioSapatos;
        }
        public RetornarListaSapatosResponse Executar()
        {
            var response = new RetornarListaSapatosResponse();
            try
            {
                //codigo para forçar o caso de teste!
                    /*response.msg = "Erro ao retornar lista de sapatos!";
                    return response;*/
                Console.WriteLine(_repositorioSapatos);
                response.ListaSapato = _repositorioSapatos.RetornarListaSapato();
                response.msg = "Lista de Sapatos retornado com sucesso!";
                return response;
            }
            catch
            {
                response.msg = "Erro ao retornar lista de sapatos!";
                return response;
            }

        }
    }
}
