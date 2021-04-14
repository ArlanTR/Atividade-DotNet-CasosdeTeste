using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.RetornarListaSapato;
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

    public class RetornarListaSapatosUseCaseTest
    {
        private readonly Mock<IRepositorioSapatos> _repositoriosSapatos;
        private readonly Mock<IRetornarListaSapatosUseCase> _retornarListaSapatos;
        private readonly IRetornarListaSapatosUseCase _useCase;
        public RetornarListaSapatosUseCaseTest()
        {
            _repositoriosSapatos = new Mock<IRepositorioSapatos>();
            _retornarListaSapatos = new Mock<IRetornarListaSapatosUseCase>();
            _useCase = new RetornarListaSapatosUseCase(_repositoriosSapatos.Object);
        }

        [Fact]
        public void Sapato_RetornarlistaSapato_QuandoRetornarSucesso()
        {
            var mensagem = "Lista de Sapatos retornado com sucesso!";
            var result = _useCase.Executar();
            result.msg.Should().BeEquivalentTo(mensagem);
        }
        [Fact]
        public void Sapato_RetornarlistaSapato__QuantoRepositorioExecao()
        {
            var sapato = new Sapato();
            var response = new RetornarListaSapatosResponse();
            response.msg = "Erro ao retornar lista de sapatos!";
            _repositoriosSapatos.Setup(repositorio => repositorio.RetornarListaSapato()).Throws(new Exception());
            var result = _useCase.Executar();
            result.Should().BeEquivalentTo(response);
        }
    }
}
