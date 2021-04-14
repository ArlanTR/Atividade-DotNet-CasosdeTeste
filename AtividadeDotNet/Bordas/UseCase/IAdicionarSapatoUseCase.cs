using AtividadeDotNet.DTO.AdicionarSapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Bordas.UseCase
{
    public interface IAdicionarSapatoUseCase
    {
        AdicionarSapatoResponse Executar(AdicionarSapatoRequest request);
    }
}
