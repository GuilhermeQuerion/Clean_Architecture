using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Application.Handlers.Tarefas;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAddTarefaHandler, AddTarefaHandler>()
                .AddTransient<IUpdateTarefaHandler, UpdateTarefaHandler>()
                .AddTransient<IDeleteTarefaHandler, DeleteTarefaHandler>()
                .AddTransient<IGetAllHandler, GetAllHandler>()
                .AddTransient<IGetTarefaHandler, GetTarefaHandler>();

            return services;
        }
    }
}
