using cadastroTarefas_assino.Models;

namespace cadastroTarefas_assino.Repository
{
    public interface ITarefaRepository
    {
        TarefaModel listarPorId(int id);
        List<TarefaModel> buscarTarefas();
        TarefaModel Criar(TarefaModel tarefa);

        TarefaModel Atualizar(TarefaModel tarefa);

        bool Deletar(int id);
    }
}
