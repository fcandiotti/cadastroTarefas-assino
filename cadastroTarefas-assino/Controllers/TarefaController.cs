using cadastroTarefas_assino.Models;
using cadastroTarefas_assino.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cadastroTarefas_assino.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }
        public IActionResult Index()
        {
            List<TarefaModel> tarefas = _tarefaRepository.buscarTarefas();
            return View(tarefas);
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

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            _tarefaRepository.Criar(tarefa);
            return RedirectToAction("Index");
        }
    }
}
