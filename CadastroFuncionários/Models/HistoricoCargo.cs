using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Models
{
    public class HistoricoCargo
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
