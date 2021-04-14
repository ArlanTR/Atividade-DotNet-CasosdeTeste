using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.DTO.RetornarListaSapato;

namespace AtividadeDotNet.Bordas.UseCase
{
    public interface IRetornarListaSapatosUseCase
    {
        RetornarListaSapatosResponse Executar();
    }
}
