using AtividadeDotNet.context;
using AtividadeDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AtividadeDotNet.Services
{
    public class SapatoService : ISapatoService
    {
        private readonly LocalDbContext _local;

        public SapatoService(LocalDbContext local)
        {
            _local = local;
        }
        public bool AdicionarSapato(Sapato sapato)
        {
            _local.sapato.Add(sapato);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarSapato(Sapato novoSapato)
        {
            _local.sapato.Attach(novoSapato);
            _local.Entry(novoSapato).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarSapato(int id)
        {
            var objApagar = _local.sapato.Where(d => d.id == id).FirstOrDefault();
            _local.sapato.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public Sapato RetornaSapatoPorId(int id)
        {
            return _local.sapato.Where(d => d.id == id).FirstOrDefault();
        }

        public List<Sapato> RetornarListaSapato()
        {
            return _local.sapato.ToList();
        }
    }
}
