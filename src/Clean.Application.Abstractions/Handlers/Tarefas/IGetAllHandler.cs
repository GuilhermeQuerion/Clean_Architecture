using Clean.Domain.Entities;

namespace Clean.Application.Abstractions.Handlers.Tarefas
{
    public interface IGetAllHandler
    {
        Tarefa[] Handle();
    }
}
