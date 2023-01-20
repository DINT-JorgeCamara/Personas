using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Clases;
using Personas.Mensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.ConsultaPersona
{
    class ConsultaPersonaVM : ObservableRecipient
    {
        private Persona personaConsulta;
        public Persona PersonaConsulta
        {
            get { return personaConsulta; }
            set { SetProperty(ref personaConsulta, value); }
        }
        public ConsultaPersonaVM()
        {
            PersonaConsulta = WeakReferenceMessenger.Default.Send<PersonaRequestMessage>();
        }
    }
}
