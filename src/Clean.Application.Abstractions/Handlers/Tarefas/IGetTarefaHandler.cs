using Clean.Domain.Entities;

namespace Clean.Application.Abstractions.Handlers.Tarefas
{
    public interface IGetTarefaHandler
    {
        Tarefa Handle(Guid id);
    }
}
