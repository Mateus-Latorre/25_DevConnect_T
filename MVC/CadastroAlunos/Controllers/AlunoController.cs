using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadastroAlunos.Models;
using Microsoft.EntityFrameworkCore;
namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly CadastroAlunosContext _context;
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger, CadastroAlunosContext context)
        {
            _logger = logger;
            _context = context;
        }
        // public IActionResult Index()
        // {
        //     return View(alunos);
        // }
        public async Task<IActionResult> Index()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return View(alunos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            _context.Add(aluno);
            await  _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}