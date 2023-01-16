using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.ListadoDePersonasVM
{
    class ListadoDePersonasVM : ObservableObject
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
            Personas = new ObservableCollection<Persona>();
            Personas.Add(new Persona("Pietro", 30, "Italiana"));
            Personas.Add(new Persona("Julia", 25, "Española"));
            Personas.Add(new Persona("Sophie", 35, "Francesa"));

        }

    }
}
