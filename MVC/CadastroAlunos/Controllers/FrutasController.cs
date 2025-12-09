using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunos.Controllers
{

    public class FrutasController : Controller
    {
        private readonly CadastroAlunosContext _context;
        private readonly ILogger<FrutasController> _logger;

        public FrutasController(ILogger<FrutasController> logger, CadastroAlunosContext context)
        {
            _logger = logger;
            _context = context;
        }

        private static List<Frutas> frutas = new List<Frutas>()
        {
        };

        public async Task<IActionResult> Index()
        {
            var frutas = await _context.Frutas.ToListAsync();
            return View(frutas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Frutas fruta)
        {
            return RedirectToAction("Index");
        }
        public IActionResult FrutasCitricas()
        {
            return View();
        }
        public IActionResult FrutasTropicais()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}