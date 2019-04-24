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

namespace Ejercicio1_9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int nDatos = int.Parse(txtDatos.Text);
            int resultado = 0;
            lblResultado.Content = "";
            nDatos++;

            for (int i = 1; i < nDatos; i++)
            {
                resultado += i;
            }

            lblResultado.Content = resultado.ToString();

            txtDatos.Text = "";
            txtDatos.Focus();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            wndPrincipal.Close();
        }
    }
}
