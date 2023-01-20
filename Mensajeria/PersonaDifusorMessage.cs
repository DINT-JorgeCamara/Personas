using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using Personas.Clases;

namespace Personas.Mensajeria
{
    public class PersonaDifusorMessage : ValueChangedMessage<Persona>
    {
        public PersonaDifusorMessage(Persona persona) : base(persona) { }
    }
}
