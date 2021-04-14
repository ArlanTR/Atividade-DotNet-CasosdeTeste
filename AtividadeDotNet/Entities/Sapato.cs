using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AtividadeDotNet.Entities
{
    public class Sapato
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string marca { get; set; }

        public int valor { get; set; }
    }
}
