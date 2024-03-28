using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Abstractions.Repositories;
using Clean.Application.Abstractions.Services;
using Clean.Domain.Entities;
using Clean.Domain.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Handlers.Tarefas
{
    public class AddTarefaHandler : NotificacaoHandler, IAddTarefaHandler
    {
        private readonly ITarefaRepository _tarefaRepository;

        public AddTarefaHandler(ITarefaRepository tarefaRepository, IEnumerable<INotificacaoService> services) : base(services)
        {
            _tarefaRepository = tarefaRepository;
        }

        public Tarefa Handle(Tarefa tarefa)
        {
            ArgumentNullException.ThrowIfNull(tarefa);

            if (string.IsNullOrWhiteSpace(tarefa.Titulo))
            {
                throw new ValidacaoException($"A propriedade {nameof(Tarefa.Titulo)} é obrigatória");
            }

            tarefa.Id = Guid.NewGuid();
            _tarefaRepository.Insert(tarefa);

            Notificar($"A tarefa {tarefa.Titulo} foi criada");

            return tarefa;
        }
    }

}
