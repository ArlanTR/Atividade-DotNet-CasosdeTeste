using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.DTO.RemoverSapato;

namespace AtividadeDotNet.Bordas.UseCase
{
    public interface IRemoverSapatoUseCase
    {
        RemoverSapatoResponse Executar(int request);
    }
}
