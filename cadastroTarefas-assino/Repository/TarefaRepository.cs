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

        public TarefaModel listarPorId(int id)
        {
            return _bancoContext.Tarefas.FirstOrDefault(x => x.id == id);
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

        public TarefaModel Atualizar(TarefaModel tarefa)
        {
            TarefaModel tarefaAntiga = listarPorId(tarefa.id);

            if (tarefaAntiga == null) throw new System.Exception("Houve um erro na atualização da tarefa!");

            tarefaAntiga.titulo = tarefa.titulo;
            tarefaAntiga.descricao = tarefa.descricao;
            tarefaAntiga.dataFinalizacao = tarefa.dataFinalizacao;

            _bancoContext.Tarefas.Update(tarefaAntiga);
            _bancoContext.SaveChanges();
            return tarefaAntiga;
        }

        public bool Deletar(int id)
        {
            TarefaModel tarefa = listarPorId(id);

            if (tarefa == null) throw new System.Exception("Houve um erro na deleção da tarefa!");

            _bancoContext.Tarefas.Remove(tarefa);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
