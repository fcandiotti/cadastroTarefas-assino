using cadastroTarefas_assino.Data;
using cadastroTarefas_assino.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroTarefas_assino.Test.Repository
{
    public class TarefaRepositoryTest
    {
        private readonly ITarefaRepository repository;
        private readonly Mock<BancoContext> bancoContext;

        public TarefaRepositoryTest()
        {
            bancoContext= new Mock<BancoContext>();
            repository = new TarefaRepository()
                bancoContext.
    }

    }
}
