using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Entities;
using AtividadeDotNet.UseCase;
using AtividadeDotNetTeste.Builder;
using FluentAssertions;
using Moq;
using System;
using Xunit;

namespace AtividadeDotNetTeste.UseCase
{
    public class AdicionarSapatoUseCaseTest
    {
        private readonly Mock<IRepositorioSapatos> _repositoriosSapatos;
        private readonly Mock<IAdicionarSapatoAdapter> _adicionarSapatoAdapter;
        private readonly AdicionarSapatoUseCase _useCase;

        public AdicionarSapatoUseCaseTest()
        {
            _repositoriosSapatos = new Mock<IRepositorioSapatos>();
            _adicionarSapatoAdapter = new Mock<IAdicionarSapatoAdapter>();
            _useCase = new AdicionarSapatoUseCase(_repositoriosSapatos.Object, _adicionarSapatoAdapter.Object);
        }

        [Fact]
        public void Sapato_AdicionarSapato_QuandoRetornarSucesso()
        {
            var request = new AdicionarSapatoRequestBuilder().Build();
            var response = new AdicionarSapatoResponse();
            var sapato = new Sapato();
            response.msg = "Sapato adicionado com sucesso!";
            _repositoriosSapatos.Setup(repositorio => repositorio.Add(sapato));
            _adicionarSapatoAdapter.Setup(adapter => adapter.converterResquesteParaSapato(request)).Returns(sapato);

            var result = _useCase.Executar(request);
            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Sapato_AdicionarSapato_NomeMenorque1()
        {
            var request = new AdicionarSapatoRequestBuilder().WithNameLength(0).Build();
            var response = new AdicionarSapatoResponse();
            var sapato = new Sapato();
            response.msg = "Erro ao Adicionar produto Nome invalido";
            var result = _useCase.Executar(request);
            response.Should().BeEquivalentTo(result);

        }
        [Fact]
        public void Sapato_AdicionarSapato_QuantoRepositorioExecao()
        {
            var request = new AdicionarSapatoRequestBuilder().Build();
            var response = new AdicionarSapatoResponse();
            var sapato = new Sapato();
            response.msg = "Erro ao Adicionar Sapato!";
            _repositoriosSapatos.Setup(repositorio => repositorio.Add(sapato));
            _adicionarSapatoAdapter.Setup(adapter => adapter.converterResquesteParaSapato(request)).Throws(new Exception());
            var result = _useCase.Executar(request);
            response.Should().BeEquivalentTo(result);

        }
    }
}
