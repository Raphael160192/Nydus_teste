using CadastroFuncionários.Data;
using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly ApplicationContext _context;

        public EmpresaRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<Empresa> GetCargos()
        {
            return _context.Empresas.ToList();
        }
        public void AddEmpresa(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public Empresa GetByIdEmpresa(int id)
        {
            return _context.Empresas.Find(id);
        }

        public List<Empresa> GetListEmpresas()
        {
            return _context.Empresas.ToList();
        }

        public void UpdateEmpresa(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
            _context.SaveChanges();
        }

        public void DeleteEmpresa(Empresa empresa)
        {
            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
        }
    }
}
