using CadastroFuncionários.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Interfaces
{
    public interface IHistoricoCargoRepository
    {
        IEnumerable<HistoricoCargo> GetHistoricoCargos();
        HistoricoCargo GetHistoricoCargoById(int id);
        void AddHistoricoCargo(HistoricoCargo historicoCargo);
        void UpdateHistoricoCargo(HistoricoCargo historicoCargo);
        void DeleteHistoricoCargo(HistoricoCargo historicoCargo);
    }
}
