using cadastroTarefas_assino.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cadastroTarefas_assino.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            HomeModel home = new HomeModel
            {
                nome = "Professor X",
                email = "professorX@assino.com.br"
            };

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}