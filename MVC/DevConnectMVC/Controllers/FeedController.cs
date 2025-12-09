
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {

        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
           TbPublicacao novaPublicacao = new TbPublicacao
           {
            Descricao = form["Descricao"].ToString(),
           };
           return View();
           }
        public IActionResult Index()
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