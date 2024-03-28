using Clean.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Abstractions.Repositories
{
    public interface ITarefaRepository
    {
        void Insert(Tarefa tarefa);

        void Delete(Guid id);

        void Update(Tarefa tarefa);

        Tarefa Get(Guid id);

        Tarefa[] GetAll();
    }
}
