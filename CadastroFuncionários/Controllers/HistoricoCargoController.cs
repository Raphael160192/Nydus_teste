using CadastroFuncionários.Interfaces;
using CadastroFuncionários.Models;
using Microsoft.AspNetCore.Mvc;

public class HistoricoCargoController : Controller
{
    private readonly IHistoricoCargoRepository _historicoCargoRepository;
    private readonly IColaboradorRepository _colaboradorRepository;
    private readonly ICargoRepository _cargoRepository;

    public HistoricoCargoController(IHistoricoCargoRepository historicoCargoRepository, IColaboradorRepository colaboradorRepository, ICargoRepository cargoRepository)
    {
        _historicoCargoRepository = historicoCargoRepository;
        _colaboradorRepository = colaboradorRepository;
        _cargoRepository = cargoRepository;
    }

    public IActionResult Index()
    {
        var historicoCargos = _historicoCargoRepository.GetHistoricoCargos();
        return View(historicoCargos);
    }

    public IActionResult Create()
    {
        ViewBag.Colaboradores = _colaboradorRepository.GetColaboradores();
        ViewBag.Cargos = _cargoRepository.GetCargos();
        return View();
    }

    [HttpPost]
    public IActionResult Create(HistoricoCargo historicoCargo)
    {
        if (ModelState.IsValid)
        {
            _historicoCargoRepository.AddHistoricoCargo(historicoCargo);
            return RedirectToAction("Index");
        }

        ViewBag.Colaboradores = _colaboradorRepository.GetColaboradores();
        ViewBag.Cargos = _cargoRepository.GetCargos();
        return View(historicoCargo);
    }

    public IActionResult Edit(int id)
    {
        var historicoCargo = _historicoCargoRepository.GetHistoricoCargoById(id);
        if (historicoCargo == null)
        {
            return NotFound();
        }

        ViewBag.Colaboradores = _colaboradorRepository.GetColaboradores();
        ViewBag.Cargos = _cargoRepository.GetCargos();
        return View(historicoCargo);
    }

    [HttpPost]
    public IActionResult Edit(HistoricoCargo historicoCargo)
    {
        var historicoCargoExistente = _historicoCargoRepository.GetHistoricoCargoById(historicoCargo.Id);

        if (historicoCargoExistente != null && historicoCargoExistente.DataDemissao != null)
        {
            ModelState.AddModelError("", "Não é possível editar o histórico de um colaborador demitido.");
        }

        if (ModelState.IsValid)
        {
            _historicoCargoRepository.UpdateHistoricoCargo(historicoCargo);
            return RedirectToAction("Index");
        }

        ViewBag.Colaboradores = _colaboradorRepository.GetColaboradores();
        ViewBag.Cargos = _cargoRepository.GetCargos();
        return View(historicoCargo);
    }


    [HttpPost]
    public IActionResult Delete(int id)
    {
        var historicoCargo = _historicoCargoRepository.GetHistoricoCargoById(id);
        if (historicoCargo == null)
        {
            return NotFound();
        }

        _historicoCargoRepository.DeleteHistoricoCargo(historicoCargo);
        return RedirectToAction("Index");
    }
}
