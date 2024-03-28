using Clean.Application.Abstractions.Repositories;
using Clean.Application.Abstractions.Services;
using Clean.Infra.Repositories;
using Clean.Infra.Services;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddSingleton<ITarefaRepository, TarefaRepository>();
            services.AddTransient<INotificacaoService, NotificacaoEmailService>();
            services.AddTransient<INotificacaoService, NotificacaoSmsService>();
            services.AddTransient<INotificacaoService, NotificaoPushService>();
            services.AddTransient<INotificacaoService, NotificaoMorseService>();

            return services;
        }
    }
}
