using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Abstractions.Repositories;
using Clean.Domain.Entities;

namespace Clean.Application.Handlers.Tarefas
{
    public class GetTarefaHandler : IGetTarefaHandler
    {
        private readonly ITarefaRepository _tarefaRepository;

        public GetTarefaHandler(ITarefaRepository tarefaRepository) {
            _tarefaRepository = tarefaRepository;
        }

        public Tarefa Handle(Guid id)
        {
            return _tarefaRepository.Get(id);
        }
    }

}
