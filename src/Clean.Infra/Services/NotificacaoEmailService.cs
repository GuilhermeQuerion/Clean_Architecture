using Clean.Application.Abstractions.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra.Services
{
    public class NotificacaoEmailService : INotificacaoService
    {
        public void Notificar(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Email: {mensagem}");
        }
    }
}
