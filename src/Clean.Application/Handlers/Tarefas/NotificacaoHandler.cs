using Clean.Application.Abstractions.Services;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Handlers.Tarefas
{
    public abstract class NotificacaoHandler
    {
        private readonly IEnumerable<INotificacaoService> _services;

        protected NotificacaoHandler(IEnumerable<INotificacaoService> services) {
            _services = services;
        } 

        protected void Notificar(string mensagem)
        {
            if (_services?.Any() == true)
            {
                foreach (var service in _services)
                {
                    service.Notificar(mensagem);
                }
            }

        }
    }
}
