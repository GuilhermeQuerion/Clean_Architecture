using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Abstractions.Services
{
    public interface INotificacaoService
    {
        void Notificar(string mensagem);
    }
}
