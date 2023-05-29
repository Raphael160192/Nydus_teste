using System;
using System.Linq;
using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFuncionários.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly ICargoRepository _cargoRepository;
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IHistoricoCargoRepository _historicoCargoRepository;

        public ColaboradorController(IColaboradorRepository colaboradorRepository, ICargoRepository cargoRepository, IEmpresaRepository empresaRepository, IHistoricoCargoRepository historicoCargoRepository)
        {
            _colaboradorRepository = colaboradorRepository;
            _cargoRepository = cargoRepository;
            _empresaRepository = empresaRepository;
            _historicoCargoRepository = historicoCargoRepository;
        }

        public IActionResult Index()
        {
            var colaboradores = _colaboradorRepository.GetColaboradores();
            return View(colaboradores);
        }

        public IActionResult Create()
        {
            var cargos = _cargoRepository.GetCargos();
            var empresas = _empresaRepository.GetEmpresas();

            ViewBag.Cargos = cargos;
            ViewBag.Empresas = empresas;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _colaboradorRepository.AddColaborador(colaborador);
                return RedirectToAction("Index");
            }

            var cargos = _cargoRepository.GetCargos();
            var empresas = _empresaRepository.GetEmpresas();

            ViewBag.Cargos = cargos;
            ViewBag.Empresas = empresas;

            return View(colaborador);
        }

        public IActionResult Edit(int id)
        {
            var colaborador = _colaboradorRepository.GetColaboradorById(id);

            if (colaborador == null)
            {
                return NotFound();
            }

            if (colaborador.DataDemissao != null)
            {
                ModelState.AddModelError("", "Não é possível editar um colaborador demitido.");
            }

            var cargos = _cargoRepository.GetCargos();
            var empresas = _empresaRepository.GetEmpresas();

            ViewBag.Cargos = cargos;
            ViewBag.Empresas = empresas;

            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Edit(int id, Colaborador colaborador)
        {
            if (id != colaborador.Id)
            {
                return NotFound();
            }

            var colaboradorExistente = _colaboradorRepository.GetColaboradorById(id);

            if (colaboradorExistente != null && colaboradorExistente.DataDemissao != null)
            {
                ModelState.AddModelError("", "Não é possível editar um colaborador demitido.");
            }

            if (ModelState.IsValid)
            {
                _colaboradorRepository.UpdateColaborador(colaborador);
                return RedirectToAction("Index");
            }

            var cargos = _cargoRepository.GetCargos();
            var empresas = _empresaRepository.GetEmpresas();

            ViewBag.Cargos = cargos;
            ViewBag.Empresas = empresas;

            return View(colaborador);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var colaborador = _colaboradorRepository.GetColaboradorById(id);

            if (colaborador == null)
            {
                return NotFound();
            }

            _colaboradorRepository.DeleteColaborador(colaborador);
            return RedirectToAction("Index");
        }
    }
}
