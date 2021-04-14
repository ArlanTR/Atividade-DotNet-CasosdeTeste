using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.DTO.AtualizarSapato;

namespace AtividadeDotNet.Bordas.UseCase
{
    public interface IAtualizarSapatoUseCase
    {
        AtualizarSapatoResponse Executar(AtualizarSapatoRequest request);
    }
}
