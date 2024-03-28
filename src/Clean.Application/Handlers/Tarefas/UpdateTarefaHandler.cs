using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Abstractions.Repositories;
using Clean.Application.Abstractions.Services;
using Clean.Domain.Entities;
using Clean.Domain.Exceptions;

namespace Clean.Application.Handlers.Tarefas
{
    public class UpdateTarefaHandler : NotificacaoHandler, IUpdateTarefaHandler
    {
        private readonly ITarefaRepository _tarefaRepository;

        public UpdateTarefaHandler(ITarefaRepository tarefaRepository, IEnumerable<INotificacaoService> services) : base(services) {
            _tarefaRepository = tarefaRepository;
        }

        public Tarefa Handle(Tarefa tarefa)
        {
            ArgumentNullException.ThrowIfNull(tarefa);

            if (string.IsNullOrWhiteSpace(tarefa.Titulo))
            {
                throw new ValidacaoException($"A propriedade {nameof(Tarefa.Titulo)} é obrigatória");
            }

            _tarefaRepository.Update(tarefa);

            Notificar($"A tarefa {tarefa.Titulo} foi atualizada");
            return tarefa;
        }
    }

}
