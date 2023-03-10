using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personas.AñadirNacionalidad
{
    /// <summary>
    /// Lógica de interacción para AnyadirNacionalidad.xaml
    /// </summary>
    public partial class AnyadirNacionalidad : Window
    {
        private AnyadirNacionalidadVM vm;
        public AnyadirNacionalidad()
        {
            InitializeComponent();
            vm = new AnyadirNacionalidadVM();
            this.DataContext = vm;
        }

        private void AceptarNacionalidadClick(object sender, RoutedEventArgs e)
        {
            vm.AceptarNacionalidad();
            DialogResult = true;
        }
    }
}
