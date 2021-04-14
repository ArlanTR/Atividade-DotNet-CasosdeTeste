using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.RetornarSapatoPorId;
using AtividadeDotNet.Entities;
using AtividadeDotNet.UseCase;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AtividadeDotNetTeste.UseCase
{
    public class RetornarSapatoPorIDUseCaseTest
    {
        private readonly Mock<IRepositorioSapatos> _repositoriosSapatos;
        private readonly Mock<IRetornarSapatoPorIDUseCase> _retornarSapatoPorId;
        private readonly RetornarSapatoPorIDUseCase _useCase;
        public RetornarSapatoPorIDUseCaseTest()
        {
            _repositoriosSapatos = new Mock<IRepositorioSapatos>();
            _retornarSapatoPorId = new Mock<IRetornarSapatoPorIDUseCase>();
            _useCase = new RetornarSapatoPorIDUseCase(_repositoriosSapatos.Object);
        }
        [Fact]
        public void Sapato_ProcurarSapatoPoId_QuandoRetornarSucesso()
        {
            var request = new RetornarSapatoPorIDRequest();
            var response = new RetornarSapatoPorIDResponse();
            var sapato = new Sapato();
            int id = 1;
            response.msg = "Sapato encontrado com sucesso!";
            var result = _useCase.Executar(id);
            response.Should().BeEquivalentTo(result);
        }
        [Fact]
        public void Sapato_AtualizarSapato__QuantoRepositorioExecao()
        {
            var request = new RetornarSapatoPorIDRequest();
            var response = new RetornarSapatoPorIDResponse();
            request.id = 1;
            response.msg = "Erro ao encontrar sapato!";
            _repositoriosSapatos.Setup(repositorio => repositorio.RetornaSapatoPorId(request.id)).Throws(new Exception());
            var result = _useCase.Executar(request.id);
            response.Should().BeEquivalentTo(result);
        }
    }
}
