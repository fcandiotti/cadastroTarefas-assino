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
        public IActionResult Editar(int id)
        {
            TarefaModel tarefa = _tarefaRepository.listarPorId(id);
            return View(tarefa);
        }
        public IActionResult DeletarConfirmacao(int id)
        {
            TarefaModel tarefa = _tarefaRepository.listarPorId(id);
            return View(tarefa);
        }

        public IActionResult Deletar(int id)
        {
            _tarefaRepository.Deletar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
                _tarefaRepository.Criar(tarefa);
                return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(TarefaModel tarefa)
        {
            _tarefaRepository.Atualizar(tarefa);
            return RedirectToAction("Index");
        }
    }
}
