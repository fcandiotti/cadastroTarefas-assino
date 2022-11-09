using Microsoft.AspNetCore.Mvc;

namespace cadastroTarefas_assino.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult DeletarConfirmacao()
        {
            return View();
        }
    }
}
