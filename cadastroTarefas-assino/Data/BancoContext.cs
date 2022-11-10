using cadastroTarefas_assino.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastroTarefas_assino.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> opt) : base(opt)
        {
        }

        public DbSet<TarefaModel> Tarefas { get; set; }
    }
}
