using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeDotNet.DTO.AdicionarSapato;
using Bogus;

namespace AtividadeDotNetTeste.Builder
{
    public class AdicionarSapatoRequestBuilder
    {
        private readonly Faker _Faker = new Faker("pt_BR");
        private readonly AdicionarSapatoRequest _adicionarSapato;
        public AdicionarSapatoRequestBuilder() 
        {
            _adicionarSapato = new AdicionarSapatoRequest();
            _adicionarSapato.nome = _Faker.Random.String(40);
            _adicionarSapato.marca = _Faker.Random.String(40);
        }
        public AdicionarSapatoRequestBuilder WithNameLength(int tamanho) 
        {
            _adicionarSapato.nome = _Faker.Random.String(tamanho);
            return this;
        }
        public AdicionarSapatoRequest Build() 
        {
            return _adicionarSapato;
        }

    }
}
