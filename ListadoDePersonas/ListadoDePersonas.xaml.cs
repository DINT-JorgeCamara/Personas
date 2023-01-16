using System.Windows.Controls;

namespace Personas.ListadoDePersonas
{
    /// <summary>
    /// Lógica de interacción para ListadoDePersonas.xaml
    /// </summary>
    public partial class ListadoDePersonas : UserControl
    {
        private ListadoDePersonasVM.ListadoDePersonasVM vm;
        public ListadoDePersonas()
        {
            InitializeComponent();
            vm = new ListadoDePersonasVM.ListadoDePersonasVM();
            this.DataContext = vm;
        }
    }
}
