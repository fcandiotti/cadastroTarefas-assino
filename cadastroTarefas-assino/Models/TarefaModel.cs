namespace cadastroTarefas_assino.Models
{
    public class TarefaModel
    {
        public int id { get; set; }
        public string? titulo { get; set; }
        public string? descricao { get; set; }
        public DateTime? dataFinalizacao { get; set; }
    }
}
