using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Clases;
using Personas.Mensajeria;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.NuevaPersona
{
    class NuevaPersonaVM : ObservableRecipient
    {
        private Persona personaNueva;
        public Persona PersonaNueva
        {
            get { return personaNueva; }
            set { SetProperty(ref personaNueva, value); }
        }

        private ObservableCollection<string> nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }



        public RelayCommand AñadirNacionalidadBtn { get; }
        public RelayCommand AceptarBtn { get; }
        private ServicioNavegacion servicioNavegacion;

        public NuevaPersonaVM()
        {
            servicioNavegacion = new ServicioNavegacion();
            Nacionalidades = new ObservableCollection<string>();

            PersonaNueva = new Persona();

            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");

            AñadirNacionalidadBtn = new RelayCommand(AñadirNacionalidad);
            AceptarBtn = new RelayCommand(Aceptar);

            WeakReferenceMessenger.Default.Register<MensajeDifusorMessage>(this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });
        }

        private void Aceptar()
        {
            WeakReferenceMessenger.Default.Send(new PersonaDifusorMessage(PersonaNueva));
        }

        private void AñadirNacionalidad()
        {
            bool? resultado = servicioNavegacion.DialogoNacionalidad();
        }
    }
}
