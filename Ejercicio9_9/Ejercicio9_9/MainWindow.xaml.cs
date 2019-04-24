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

namespace Ejercicio9_9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int contadorTirada = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            contadorTirada++;

            // Calculamos el resultado con el random
            numero = rnd.Next(1, 7);

            // Pasamos al tbxResultado lo que ha salido mantiendo un indice
            tbxResultado.Inlines.Add(new LineBreak());
            tbxResultado.Text += contadorTirada + " -> " + numero;
        }
    }
}
