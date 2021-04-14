using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AtividadeDotNet.Services
{
    public interface ISapatoService
    {
        bool AdicionarSapato(Sapato sapato);
        List<Sapato> RetornarListaSapato();
        Sapato RetornaSapatoPorId(int id);
        bool AtualizarSapato(Sapato novoSapato);
        bool DeletarSapato(int id);
    }
}
