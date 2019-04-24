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

namespace Ejercicio2_9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] numeros = null;
        List<char> operadores = new List<char>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtExpresion_KeyDown(object sender, KeyEventArgs e)
        {
            // True si no se puede pulsar
            e.Handled = !ValidarEntrada(e.Key);
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double resultado = 0;

            // Sacar la lista de números
            ListaNumeros(txtExpresion.Text);

            // Sacar el orden de los operadores
            ListaOperadores(txtExpresion.Text);

            // Hacer operaciones
            resultado = double.Parse(numeros[0]);
            resultado = Calcular(resultado);
            
            // Sacar en la app
            txtResultado.Text = resultado.ToString();
        }

        //METODOS PROPIOS
        bool ValidarEntrada(Key tecla)
        {
            Key[] permitidas = { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8, Key.D9, Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4, Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9, Key.OemBackslash, Key.OemPlus, Key.OemMinus, Key.Multiply };
            return permitidas.Contains(tecla);
        }

        void ListaNumeros(string texto)
        {
            char[] separadores = { '+', '-', '/', '*' };
            numeros = texto.Split(separadores);
        }

        void ListaOperadores(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                char CharAComprobar = char.Parse(texto.Substring(i, 1));
                if (CharAComprobar == '+' || CharAComprobar == '-' || CharAComprobar == '/' || CharAComprobar == '*')
                    operadores.Add(CharAComprobar);
            }
        }

        double Calcular(double resultado)
        {
            int contadorNum = 1;
            for (int i = 0; i < operadores.Count; i++)
            {
                switch (operadores[i])
                {
                    case '+':
                        resultado += double.Parse(numeros[contadorNum]);
                        break;
                    case '-':
                        resultado -= double.Parse(numeros[contadorNum]);
                        break;
                    case '/':
                        resultado = resultado / double.Parse(numeros[contadorNum]);
                        break;
                    case '*':
                        resultado = resultado * double.Parse(numeros[contadorNum]);
                        break;
                }
                contadorNum++;
            }
            return resultado;
        }
    }
}
