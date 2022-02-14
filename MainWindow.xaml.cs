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
using EjerciciosCap8_Cap9.Cap8_Ejercicio3;
using EjerciciosCap8_Cap9.Cap8_Ejercicio5;

namespace EjerciciosCap8_Cap9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio3Button_Click(object sender, RoutedEventArgs e)
        {
            var Ejercicio3Cap8 = new Ejercicio3Cap8();
            Ejercicio3Cap8.Show();
        }

        private void Ejercicio4Button_Click(object sender, RoutedEventArgs e)
        {
            var Ejercicio5Cap8 = new Ejercicio5Cap8();
            Ejercicio5Cap8.Show();

        }
    }

   
}
