using System.Windows.Controls;

namespace Personas.NuevaPersona
{
    /// <summary>
    /// Lógica de interacción para NuevaPersona.xaml
    /// </summary>
    public partial class NuevaPersona : UserControl
    {
        private NuevaPersonaVM vm;
        public NuevaPersona()
        {
            InitializeComponent();
            vm = new NuevaPersonaVM();
            this.DataContext = vm;
        }
    }
}
