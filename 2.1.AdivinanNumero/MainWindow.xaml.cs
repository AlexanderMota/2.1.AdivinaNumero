using System;
using System.Windows;

namespace _2._1.AdivinanNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random gen = new Random();
        private int num;
        public MainWindow()
        {
            InitializeComponent();
            num = gen.Next(0, 100);
        }
        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroTextBox.Text) == num) textoOutput.Text = "Número: Correcto!";
            else textoOutput.Text = $"{(int.Parse(numeroTextBox.Text) < num ? "Número: Es muy pequeño!" : "Número: Es muy grande!")}";
        }

        private void ReiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            textoOutput.Text = "Número: ";
            num = gen.Next(0, 100);
        }
    }
}
