using Clean.Application.Abstractions.Services;

namespace Clean.Infra.Services
{
    public class NotificacaoSmsService : INotificacaoService
    {
        public void Notificar(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sms: {mensagem}");
        }
    }
}
