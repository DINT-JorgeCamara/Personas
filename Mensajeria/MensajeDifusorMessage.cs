using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace Personas.Mensajeria
{
    public class MensajeDifusorMessage : ValueChangedMessage<string>
    {
        public MensajeDifusorMessage(string texto) : base(texto) { }
    }
}
