using System;
using System.Windows;

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int num;

        public MainWindow()
        {
            InitializeComponent();
            num = random.Next(0, 100);
        }

        private void ButtonComprobar(object sender, RoutedEventArgs e)
        {
            if (!textoEntrada.Text.Equals(""))
            {
                if (num == Convert.ToInt32(textoEntrada.Text))
                {
                    textoAviso.Text = "Has adivinado el número.";
                }
                else if (num > Convert.ToInt32(textoEntrada.Text))
                {
                    textoAviso.Text = "Te has quedado corto.";
                }
                else
                {
                    textoAviso.Text = "Te has pasado.";
                }
            }
            else
            {
                textoAviso.Text = "Introduce un número entre 1 y 100.";
            }
        }

        private void ButtonReiniciar(object sender, RoutedEventArgs e)
        {
            textoAviso.Text = "";
            textoEntrada.Clear();
            num = random.Next(0, 100);
        }
    }
}
