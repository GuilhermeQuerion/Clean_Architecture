using Clean.Application.Abstractions.Services;

namespace Clean.Infra.Services
{
    public class NotificaoPushService : INotificacaoService
    {
        public void Notificar(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Push: {mensagem}");
        }
    }
}
