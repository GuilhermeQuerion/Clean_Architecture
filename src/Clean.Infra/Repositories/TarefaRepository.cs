using Clean.Application.Abstractions.Repositories;
using Clean.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private Dictionary<Guid, Tarefa> _tarefas;

        public TarefaRepository()
        {
            _tarefas = new Dictionary<Guid, Tarefa>();
        }

        public void Delete(Guid id)
        {
            _tarefas.Remove(id);
        }

        public Tarefa Get(Guid id)
        {
            _tarefas.TryGetValue(id, out Tarefa tarefa);
            return tarefa;
        }

        public Tarefa[] GetAll()
        {
            return _tarefas.Values.ToArray();
        }

        public void Insert(Tarefa tarefa)
        {
            _tarefas.TryAdd(tarefa.Id.Value, tarefa);
        }

        public void Update(Tarefa tarefa)
        {
            if (_tarefas.ContainsKey(tarefa.Id.Value))
            {
                _tarefas[tarefa.Id.Value] = tarefa;
            }
        }
    }
}
