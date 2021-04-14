using AtividadeDotNet.Bordas.Repositorios;
using AtividadeDotNet.context;
using AtividadeDotNet.DTO.AdicionarSapato;
using AtividadeDotNet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDotNet.Repositorios
{
    public class RepositorioSapatos : IRepositorioSapatos
    {
        private readonly LocalDbContext _local;

        public RepositorioSapatos(LocalDbContext local)
        {
            _local = local;
        }

        public void Add(Sapato request)
        {
            _local.sapato.Add(request);
            _local.SaveChanges();
        }

        public void AtualizarSapato(Sapato request)
        {
            _local.sapato.Attach(request);
            _local.Entry(request).State = EntityState.Modified;
            _local.SaveChanges();
        }

        public bool RemoverSapato(int id)
        {
                        var objApagar = _local.sapato.Where(d => d.id == id).FirstOrDefault();
            _local.sapato.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Sapato> RetornarListaSapato()
        {
            return _local.sapato.ToList();
        }

        public Sapato RetornaSapatoPorId(int id)
        {
            return _local.sapato.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
