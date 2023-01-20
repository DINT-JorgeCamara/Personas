using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion servicioNavegacion;

        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }

        public RelayCommand NuevaPersonaBtn { get; }
        public RelayCommand ListaPersonasBtn { get; }
        public RelayCommand ConsultaPersonasBtn { get; }

        public MainWindowVM()
        {
            servicioNavegacion = new ServicioNavegacion();

            NuevaPersonaBtn = new RelayCommand(CargaNuevaPersona);
            ListaPersonasBtn = new RelayCommand(CargaListaPersona);
            ConsultaPersonasBtn = new RelayCommand(ConsultaPersona);
        }

        private void ConsultaPersona()
        {
            ContenidoVentana = servicioNavegacion.VentanaConsulta();
        }

        private void CargaListaPersona()
        {
            ContenidoVentana = servicioNavegacion.VentanaListaPersonas();
        }

        private void CargaNuevaPersona()
        {
           ContenidoVentana = servicioNavegacion.VentanaNuevaPersona();
        }
    }
}
