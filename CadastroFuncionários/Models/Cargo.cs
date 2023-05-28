using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CBO { get; set; }
        public string DescricaoAtividades { get; set; }
    }
}
