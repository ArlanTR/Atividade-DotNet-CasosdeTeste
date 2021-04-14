using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeDotNet.Bordas.Adapter;
using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.DTO.RetornarSapatoPorId;

namespace AtividadeDotNet.Bordas.UseCase
{
    public interface IRetornarSapatoPorIDUseCase
    {
        RetornarSapatoPorIDResponse Executar(int request);
    }
}
