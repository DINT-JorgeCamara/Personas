using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Clases;
using Personas.Mensajeria;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.ListadoDePersonasVM
{
    class ListadoDePersonasVM : ObservableRecipient
    {
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        public ListadoDePersonasVM()
        {
            PersonaSeleccionada = new Persona();
            Personas = new ObservableCollection<Persona>
            {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
            };

            WeakReferenceMessenger.Default.Register<PersonaDifusorMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });

            WeakReferenceMessenger.Default.Register<ListadoDePersonasVM, PersonaRequestMessage>(this, (r, m) =>
            {
                if(!m.HasReceivedResponse)
                    m.Reply(PersonaSeleccionada);
            });

        }

    }
}
