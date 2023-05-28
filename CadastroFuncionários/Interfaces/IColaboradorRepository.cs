﻿using CadastroFuncionários.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFuncionários.Interfaces
{
    public interface IColaboradorRepository
    {
        IEnumerable<Colaborador> GetColaboradores();
        Colaborador GetColaboradorById(int id);
        void AddColaborador(Colaborador colaborador);
        void UpdateColaborador(Colaborador colaborador);
        void DeleteColaborador(Colaborador colaborador);
    }
}
