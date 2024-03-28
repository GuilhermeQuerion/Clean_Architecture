using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Abstractions.Repositories;
using Clean.Application.Abstractions.Services;

namespace Clean.Application.Handlers.Tarefas
{
    public class DeleteTarefaHandler : NotificacaoHandler, IDeleteTarefaHandler
    {
        private readonly ITarefaRepository _tarefaRepository;

        public DeleteTarefaHandler(ITarefaRepository tarefaRepository, IEnumerable<INotificacaoService> services) : base(services)
        {
            _tarefaRepository = tarefaRepository;
        }

        public void Handle(Guid id)
        {
            _tarefaRepository.Delete(id);
            Notificar($"A tarefa {id} foi exluída");
        }
    }

}
