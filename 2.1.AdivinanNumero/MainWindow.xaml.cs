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

namespace _2._1.AdivinanNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random gen = new Random();
        public int num;
        public MainWindow()
        {
            InitializeComponent();
            num = gen.Next(0, 100);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroTextBox.Text) == num) textoOutput.Text = "Número: Correcto!";
            else textoOutput.Text = $"{(int.Parse(numeroTextBox.Text) < num ? "Número: Es muy pequeño!" : "Número: Es muy grande!")}";
        }

        private void reiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            textoOutput.Text = "Número: ";
            num = gen.Next(0, 100);
        }
    }
}
