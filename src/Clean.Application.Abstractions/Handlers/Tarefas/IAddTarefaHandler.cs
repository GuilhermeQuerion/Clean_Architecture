using Clean.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Abstractions.Handlers.Tarefas
{
    public interface IAddTarefaHandler
    {
        Tarefa Handle(Tarefa tarefa);
    }
}
