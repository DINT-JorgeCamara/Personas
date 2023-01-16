using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.AñadirNacionalidad
{
    class AnyadirNacionalidadVM : ObservableObject
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
    }
}
