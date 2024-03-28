using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Abstractions.Repositories;
using Clean.Domain.Entities;

namespace Clean.Application.Handlers.Tarefas
{
    public class GetAllHandler : IGetAllHandler
    {
        private readonly ITarefaRepository _tarefaRepository;

        public GetAllHandler(ITarefaRepository tarefaRepository) {
            _tarefaRepository = tarefaRepository;
        }

        public Tarefa[] Handle()
        {
            return _tarefaRepository.GetAll();
        }
    }

}
