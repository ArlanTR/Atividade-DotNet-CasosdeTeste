using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeDotNet.Entities;
using AtividadeDotNet.UseCase;
using FluentAssertions;
using Moq;
using System;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using Xunit;
using AtividadeDotNet.DTO.RemoverSapato;

namespace AtividadeDotNetTeste.UseCase
{
    public class RemoverSapatoUseCaseTest
    {
        private readonly Mock<IRepositorioSapatos> _repositoriosSapatos;
        private readonly Mock<IRemoverSapatoUseCase> _removerSapato;
        private readonly RemoverSapatoUseCase _useCase;
        public RemoverSapatoUseCaseTest()
        {
            _repositoriosSapatos = new Mock<IRepositorioSapatos>();
            _removerSapato = new Mock<IRemoverSapatoUseCase>();
            _useCase = new RemoverSapatoUseCase(_repositoriosSapatos.Object);
        }
        [Fact]
        public void Sapato_ProcurarSapatoPoId_QuandoRetornarSucesso()
        {
            var request = new RemoverSapatoRequest();
            var response = new RemoverSapatoResponse();
            var sapato = new Sapato();
            int id = 1;
            response.msg = "Sucesso ao Remover sapato!";
            var result = _useCase.Executar(id);
            response.Should().BeEquivalentTo(result);
        }
        [Fact]
        public void Sapato_AtualizarSapato__QuantoRepositorioExecao()
        {
            var request = new RemoverSapatoRequest();
            var response = new RemoverSapatoResponse();
            request.id = 1;
            response.msg = "Erro ao remover sapato!";
            _repositoriosSapatos.Setup(repositorio => repositorio.RemoverSapato(request.id)).Throws(new Exception());
            var result = _useCase.Executar(request.id);
            response.Should().BeEquivalentTo(result);
        }
    }
}
