namespace Clean.Application.Abstractions.Handlers.Tarefas
{
    public interface IDeleteTarefaHandler
    {
        void Handle(Guid id);
    }
}
