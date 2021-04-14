using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Bordas.Repositorios
{
    public interface IRepositorioSapatos
    {
        public void Add(Sapato request);
        public void AtualizarSapato(Sapato request);
        bool RemoverSapato(int id);
        public List<Sapato> RetornarListaSapato();
        public Sapato RetornaSapatoPorId(int id);
    }
}
