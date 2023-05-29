using CadastroFuncionários.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Interfaces
{
    public interface IEmpresaRepository
    {
        IEnumerable<Empresa> GetEmpresas();
        void AddEmpresa(Empresa empresa);
        Empresa GetByIdEmpresa(int id);
        List<Empresa> GetListEmpresas();
        void UpdateEmpresa(Empresa empresa);
        void DeleteEmpresa(Empresa empresa);
    }
}
