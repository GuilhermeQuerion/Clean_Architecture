using Clean.Application.Abstractions.Services;

namespace Clean.Infra.Services
{
    public class NotificaoMorseService : INotificacaoService
    {
        private static readonly Dictionary<char, string> morseCodes = new Dictionary<char, string>
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."},
        {'H', "...."}, {'I', ".."},{'Í', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."},
        {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"}, {'U', "..-"},
        {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"},
        {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
        {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {' ', " "}
    };
        public void Notificar(string mensagem)
        {
            mensagem = mensagem.ToUpper();
            var result = new System.Text.StringBuilder();
            foreach (var c in mensagem)
            {
                if (morseCodes.TryGetValue(c, out string morseCode))
                {
                    result.Append(morseCode).Append(" ");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
