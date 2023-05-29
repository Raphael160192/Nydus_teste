using CadastroFuncionários.Data;
using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CadastroFuncionários.Repositories
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly ApplicationContext _context;

        public ColaboradorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Colaborador> GetColaboradores()
        {
            return _context.Colaboradores
        .Include(c => c.Cargo)
        .Include(c => c.Empresa)
        .Include(c => c.HistoricoCargos)
            .ThenInclude(hc => hc.Cargo)
        .ToList();
        }

        public Colaborador GetColaboradorById(int id)
        {
            return _context.Colaboradores.Include(c => c.Cargo).Include(c => c.Empresa).FirstOrDefault(c => c.Id == id);
        }

        public void AddColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Add(colaborador);
            _context.SaveChanges();
        }

        public void UpdateColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Update(colaborador);
            _context.SaveChanges();
        }

        public void DeleteColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Remove(colaborador);
            _context.SaveChanges();
        }
    }
}
