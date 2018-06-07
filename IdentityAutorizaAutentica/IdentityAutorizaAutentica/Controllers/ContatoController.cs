using IdentityAutorizaAutentica.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IdentityAutorizaAutentica.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult AcessoAutoruzado()
        {
            return Content("ACESSO AUTORIZADO");
        }

        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("ACESSO ANONIMO");
        }
    }
}