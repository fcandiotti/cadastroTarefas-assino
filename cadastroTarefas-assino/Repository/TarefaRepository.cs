using cadastroTarefas_assino.Data;
using cadastroTarefas_assino.Models;

namespace cadastroTarefas_assino.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly BancoContext _bancoContext;
        public TarefaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<TarefaModel> buscarTarefas()
        {
            return _bancoContext.Tarefas.ToList();
        }

        public TarefaModel Criar(TarefaModel tarefa)
        {
            _bancoContext.Tarefas.Add(tarefa);
            _bancoContext.SaveChanges();
            return tarefa;
        }
    }
}
