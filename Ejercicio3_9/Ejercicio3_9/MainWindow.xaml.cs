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

namespace Ejercicio3_9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int respuesta = 0;
        int intentos = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            respuesta = rnd.Next(1000);

            txtOculto.Text = respuesta.ToString();

            // Cambiar estado controles
            chkVerNumero.IsEnabled = true;
            chkVerNumero.IsChecked = false;
            btnProbar.IsEnabled = true;
            btnIntroducir.IsEnabled = false;
            btnGenerar.IsEnabled = false;
        }

        private void chkVerNumero_Checked(object sender, RoutedEventArgs e)
        {
            txtOculto.Visibility = Visibility.Visible;
        }

        private void chkVerNumero_Unchecked(object sender, RoutedEventArgs e)
        {
            txtOculto.Visibility = Visibility.Hidden;
        }

        private void btnIntroducir_Click(object sender, RoutedEventArgs e)
        {
            respuesta = int.Parse(txtNumero.Text);
            txtNumero.Text = "";

            txtOculto.Text = respuesta.ToString();

            // Cambiar estado controles
            chkVerNumero.IsEnabled = true;
            chkVerNumero.IsChecked = false;
            btnProbar.IsEnabled = true;
            btnIntroducir.IsEnabled = false;
            btnGenerar.IsEnabled = false;
        }

        private void btnProbar_Click(object sender, RoutedEventArgs e)
        {
            int prueba = int.Parse(txtNumero.Text);
            if (respuesta < prueba)
                txtRespuesta.Text = "NO, el número buscado es MENOR";
            else if (respuesta > prueba)
                txtRespuesta.Text = "NO, el número buscado es MAYOR";
            else
            {
                txtRespuesta.Text = "CORRECTO el número buscado era " + respuesta.ToString() + ". " + intentos + " Intentos";
                btnProbar.IsEnabled = false;
                btnReset.Visibility = Visibility.Visible;
                intentos = 1;
            }
            intentos++;

            txtNumero.Text = "";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            btnGenerar.IsEnabled = true;
            chkVerNumero.IsChecked = false;
            chkVerNumero.IsEnabled = false;
            txtOculto.Text = "";
            btnProbar.IsEnabled = false;
            btnIntroducir.IsEnabled = true;
            btnReset.Visibility = Visibility.Hidden;
            txtRespuesta.Text = "";
        }
    }
}
