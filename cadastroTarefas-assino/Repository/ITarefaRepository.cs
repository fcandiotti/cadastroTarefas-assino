using cadastroTarefas_assino.Models;

namespace cadastroTarefas_assino.Repository
{
    public interface ITarefaRepository
    {
        List<TarefaModel> buscarTarefas();
        TarefaModel Criar(TarefaModel tarefa);
   
    }
}
