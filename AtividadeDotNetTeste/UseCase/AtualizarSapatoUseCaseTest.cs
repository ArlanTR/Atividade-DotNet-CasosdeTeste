using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.DTO.AtualizarSapato;
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
    public class AtualizarSapatoUseCaseTest
    {
        private readonly Mock<IRepositorioSapatos> _repositoriosSapatos;
        private readonly Mock<IAtualizarSapatoAdapter> _atualizarSapatoAdapter;
        private readonly AtualizarSapatoUseCase _useCase;

        public AtualizarSapatoUseCaseTest()
        {
            _repositoriosSapatos = new Mock<IRepositorioSapatos>();
            _atualizarSapatoAdapter = new Mock<IAtualizarSapatoAdapter>();
            _useCase = new AtualizarSapatoUseCase(_repositoriosSapatos.Object, _atualizarSapatoAdapter.Object);
        }

        [Fact]
        public void Sapato_AtualizarSapato_QuandoRetornarSucesso()
        {
            var request = new AtualizarSapatoRequest();
            var response = new AtualizarSapatoResponse();
            var sapato = new Sapato();
            response.msg = "Sapato atualizado com sucesso!";
            var result = _useCase.Executar(request);
            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Sapato_AtualizarSapato__QuantoRepositorioExecao()
        {
            var request = new AtualizarSapatoRequest();
            var response = new AtualizarSapatoResponse();
            var sapato = new Sapato();
            response.msg = "Erro ao Atualizar Sapato!";
            _repositoriosSapatos.Setup(repositorio => repositorio.AtualizarSapato(sapato));
            _atualizarSapatoAdapter.Setup(adapter => adapter.converterResquesteParaSapato(request)).Throws(new Exception());
            var result = _useCase.Executar(request);
            response.Should().BeEquivalentTo(result);
        }
    }
}
