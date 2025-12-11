
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {
        private readonly DevConnectContext _context;

        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }
        public static List<TbPublicacao> publicacoes = new List<TbPublicacao>();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
                try
                {
                    List<TbPublicacao> publicacoes = await _context.TbPublicacao.
                    Include(p => p.IdUsuarioNavigation)
                    .ToListAsync();
                }
                catch (System.Exception)
                {

                }
            publicacoes = _context.TbPublicacao.ToList();
            return View(publicacoes);
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbPublicacao novaPublicacao = new TbPublicacao
            {
                Descricao = form["Descricao"].ToString(),
                DataPublicacao = DateOnly.FromDateTime(DateTime.Now),
            };
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(folder, file.FileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novaPublicacao.ImagemUrl = file.FileName;
            }
            try
            {
                _context.TbPublicacao.Add(novaPublicacao);
                await _context.SaveChangesAsync();
                ViewBag.PublicacaoCadastrada = "Cadastrada";

            }
            catch (System.Exception)
            {
                ViewBag.PublicacaoCadastrada = "Nao cadastrada";
            }

            var publicacoes = _context.TbPublicacao.ToList();
            return View("Index", publicacoes);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}