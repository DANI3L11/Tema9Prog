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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Slider
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Inicializar();
        }

        void Inicializar()
        {
            recPanel.Opacity = sldOpacidad.Value;
        }

        private void sldOpacidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            recPanel.Opacity = sldOpacidad.Value;
            tbxValor.Text = (sldOpacidad.Value * 100).ToString("000") + "%";
        }
    }
}
