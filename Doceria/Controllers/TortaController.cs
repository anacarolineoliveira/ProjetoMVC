using Microsoft.AspNetCore.Mvc;
using Doceria.Models;
using System.Collections.Generic;
using Doceria.ViewModel;
using Doceria.Persistence;
using System.Linq;

namespace Doceria.Controllers
{
    public class TortaController : Controller
    {
        private static DoceriaContext _context;

        public TortaController(DoceriaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index(TortaListaViewModel viewLista)
        {
            viewLista.Lista = _context.Tortas.ToList();
            return View(viewLista);//forward - get
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            TortaListaViewModel viewLista = new TortaListaViewModel();
            viewLista.Lista = _context.Tortas.ToList();
            return View(viewLista);
        }
        [HttpPost]
        public IActionResult Cadastrar(TortaListaViewModel viewTorta)
        {
            _context.Tortas.Add(viewTorta.Torta);
            _context.SaveChanges();
            TempData["sucesso"] = "Cadastro realizado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar()
        {
            TortaListaViewModel viewLista = new TortaListaViewModel();
            viewLista.Lista = _context.Tortas.ToList();
            return View(viewLista);
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var torta = _context.Tortas.Find(id);
            _context.Tortas.Remove(torta);
            return RedirectToAction("Editar");
        }

        //TempData["alteração"] = "Alteração conluída!";

    }
}
