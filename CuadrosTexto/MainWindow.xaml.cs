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

namespace CuadrosTexto
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

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            int temp = 0;

            if (e.Key == Key.F1 && (sender as TextBox).Name.Equals(nombreTextBox))
                nombreLabel.Visibility = nombreLabel.IsVisible ? Visibility.Visible : Visibility.Hidden;
            else if (e.Key == Key.F1 && (sender as TextBox).Name.Equals(apellidoTextBox))
                apellidoLabel.Visibility = apellidoLabel.IsVisible ? Visibility.Visible : Visibility.Hidden;
            else if (e.Key == Key.F2 && (sender as TextBox).Name.Equals(edadTextBox))
            {
                if (edadTextBox.Text.Length == 0 || int.TryParse(edadTextBox.Text, out temp) == false)
                    edadLabel.Visibility = Visibility.Visible;
            }
                
        }
    }
}
