using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajeria;

namespace Personas.AñadirNacionalidad
{
    class AnyadirNacionalidadVM : ObservableRecipient
    {
        private string nacionalidadNueva;
        public string NacionalidadNueva
        {
            get { return nacionalidadNueva; }
            set { SetProperty(ref nacionalidadNueva, value); }
        }
        public AnyadirNacionalidadVM()
        {
            
        }
        public void AceptarNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new MensajeDifusorMessage(NacionalidadNueva));
        }
    }
}
