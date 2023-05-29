using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CadastroFuncionários.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public IActionResult Index()
        {
            var cargos = _cargoRepository.GetCargos().ToList();
            return View(cargos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                _cargoRepository.AddCargo(cargo);
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        public IActionResult Edit(int id)
        {
            var cargo = _cargoRepository.GetCargoById(id);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Cargo cargo)
        {
            if (id != cargo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _cargoRepository.UpdateCargo(cargo);
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        public IActionResult Delete(int id)
        {
            var cargo = _cargoRepository.GetCargoById(id);
            if (cargo == null)
            {
                return NotFound();
            }

            _cargoRepository.DeleteCargo(cargo);
            return RedirectToAction("Index");
        }
    }
}
