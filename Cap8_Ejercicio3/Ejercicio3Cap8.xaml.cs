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

/* Hacer un programa que muestre la hora
del día en formato AM/FM seguida del
año, el día y el mes actual.*/

namespace EjerciciosCap8_Cap9.Cap8_Ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Ejercicio3Cap8 : Window
    {
         public Ejercicio3Cap8()
         {
             InitializeComponent();
         }

         private void DateTimeButton_Click(object sender, RoutedEventArgs e)
         {
             DateTime fecha = DateTime.Now;
             MessageBox.Show("La fecha y hora actual es: " + (fecha.ToString()), "FECHA Y HORA ACTUAL");
          

         }
    }
}
