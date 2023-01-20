using Personas.AñadirNacionalidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        private ListadoDePersonas.ListadoDePersonas listadoDePersonas;
        public ServicioNavegacion()
        {
            listadoDePersonas = new ListadoDePersonas.ListadoDePersonas();
        }
        public UserControl VentanaNuevaPersona()
        {
            return new NuevaPersona.NuevaPersona();
        }
        public UserControl VentanaListaPersonas()
        {
            return listadoDePersonas;
        }
        public bool? DialogoNacionalidad()
        {
            AnyadirNacionalidad newNacionalidadDialog = new AnyadirNacionalidad();
            return newNacionalidadDialog.ShowDialog();
        }
        public UserControl VentanaConsulta()
        {
            return new ConsultaPersona.ConsultaPersona();
        }
    }
}
