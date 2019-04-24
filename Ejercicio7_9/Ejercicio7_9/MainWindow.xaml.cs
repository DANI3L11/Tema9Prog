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

namespace Ejercicio7_9
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
            int[] matrizResultado = new int[9];

            // Calculos
            matrizResultado[0] = int.Parse(txtm11.Text) * int.Parse(txtm21.Text);
            matrizResultado[1] = int.Parse(txtm11.Text) * int.Parse(txtm22.Text);
            matrizResultado[2] = int.Parse(txtm11.Text) * int.Parse(txtm23.Text);
            matrizResultado[3] = int.Parse(txtm12.Text) * int.Parse(txtm21.Text);
            matrizResultado[4] = int.Parse(txtm12.Text) * int.Parse(txtm22.Text);
            matrizResultado[5] = int.Parse(txtm12.Text) * int.Parse(txtm23.Text);
            matrizResultado[6] = int.Parse(txtm13.Text) * int.Parse(txtm21.Text);
            matrizResultado[7] = int.Parse(txtm13.Text) * int.Parse(txtm22.Text);
            matrizResultado[8] = int.Parse(txtm13.Text) * int.Parse(txtm23.Text);

            sckGeneral.Visibility = Visibility.Hidden;
            btnCalcular.Visibility = Visibility.Hidden;
            grdPrincipal.Visibility = Visibility.Visible;
            grdPrincipal.Height = 200;

            txbm31.Text = matrizResultado[0].ToString();
            txbm32.Text = matrizResultado[1].ToString();
            txbm33.Text = matrizResultado[2].ToString();
            txbm34.Text = matrizResultado[3].ToString();
            txbm35.Text = matrizResultado[4].ToString();
            txbm36.Text = matrizResultado[5].ToString();
            txbm37.Text = matrizResultado[6].ToString();
            txbm38.Text = matrizResultado[7].ToString();
            txbm39.Text = matrizResultado[8].ToString();


            

        }
    }
}
