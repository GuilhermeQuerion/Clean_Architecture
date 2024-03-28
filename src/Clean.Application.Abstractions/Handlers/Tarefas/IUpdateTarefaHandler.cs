using Clean.Domain.Entities;

namespace Clean.Application.Abstractions.Handlers.Tarefas
{
    public interface IUpdateTarefaHandler
    {
        Tarefa Handle(Tarefa tarefa);
    }
}
