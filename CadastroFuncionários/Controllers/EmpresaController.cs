using CadastroFuncionários.Data;
using CadastroFuncionários.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CadastroFuncionários.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly ApplicationContext _context;

        public EmpresaController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var empresas = _context.Empresas.ToList();
            //return View(empresas);
            //return RedirectToAction("Create");
            return View();

        }

        public IActionResult Create()
        {
            return View(new Empresa());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Empresas.Add(empresa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        public IActionResult Edit(int id)
        {
            var empresa = _context.Empresas.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Empresa empresa)
        {
            if (id != empresa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Empresas.Update(empresa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empresa);
        }
         
        public IActionResult Delete(int id)
        {
            var empresa = _context.Empresas.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var empresa = _context.Empresas.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
