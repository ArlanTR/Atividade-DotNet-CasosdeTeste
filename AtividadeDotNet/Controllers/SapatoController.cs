using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.UseCase;
using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.DTO.AtualizarSapato;
using AtividadeDotNet.DTO.RemoverSapato;
using AtividadeDotNet.DTO.RetornarListaSapato;
using AtividadeDotNet.DTO.RetornarSapatoPorId;
using AtividadeDotNet.Entities;
using AtividadeDotNet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AtividadeDotNet.Controllers
{
    [ApiController]
    [Route("(controller)")]
    public class SapatoController : ControllerBase
    {
        private readonly ILogger<SapatoController> _logger;
        private readonly IAdicionarSapatoUseCase _adicionarSapatoUseCase;
        private readonly IAtualizarSapatoUseCase _atualizarSapatoUseCase;
        private readonly IRemoverSapatoUseCase _removerSapatoUseCase;
        private readonly IRetornarListaSapatosUseCase _retornarListaSapatosUseCase;
        private readonly IRetornarSapatoPorIDUseCase _retornarSapatoPorIDUseCase;

        public SapatoController(ILogger<SapatoController> logger, IAdicionarSapatoUseCase adicionarSapatoUseCase
                                                                , IAtualizarSapatoUseCase atualizarSapatoUseCase
                                                                , IRemoverSapatoUseCase removerSapatoUseCase
                                                                , IRetornarListaSapatosUseCase retornarListaSapatosUseCase
                                                                , IRetornarSapatoPorIDUseCase retornarSapatoPorIDUseCase)
        {
            _logger = logger;
            _adicionarSapatoUseCase = adicionarSapatoUseCase;
            _atualizarSapatoUseCase = atualizarSapatoUseCase;
            _removerSapatoUseCase = removerSapatoUseCase;
            _retornarListaSapatosUseCase = retornarListaSapatosUseCase;
            _retornarSapatoPorIDUseCase = retornarSapatoPorIDUseCase;
        }
        [HttpPost]
        public IActionResult sapatoAdd([FromBody] AdicionarSapatoRequest novoSapato)
        {
            return Ok(_adicionarSapatoUseCase.Executar(novoSapato));
        }

        [HttpPut]
        public IActionResult sapatoUpdate([FromBody] AtualizarSapatoRequest novoSapato)
        {
            return Ok(_atualizarSapatoUseCase.Executar(novoSapato));
        }

        [HttpGet]
        public IActionResult TodosSapatos()
        {
            return Ok(_retornarListaSapatosUseCase.Executar());
        }

        [HttpGet("{id}")]
        public IActionResult sapato(int id)
        {
            return Ok(_retornarSapatoPorIDUseCase.Executar(id));
        }

        [HttpDelete("{id}")]
        public IActionResult sapatoDelete(int id)
        {
            return Ok(_removerSapatoUseCase.Executar(id));
        }
    }
}
