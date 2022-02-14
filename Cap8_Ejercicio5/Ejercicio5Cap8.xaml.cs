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

/*Hacer un programa que le solicite al
usuario dos cadenas y luego las muestre
en orden alfabético.*/


namespace EjerciciosCap8_Cap9.Cap8_Ejercicio5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class Ejercicio5Cap8 : Window
    {
         public Ejercicio5Cap8()
         {
             InitializeComponent();
         }

         public void Cadena1Button_Click (object sender, RoutedEventArgs e)
         {
            string cadena;
            string ordenado;

            cadena = (Microsoft.VisualBasic.Interaction.InputBox($"Digite la Cadena A Ordenar: ", " Cadena Alfabeticamente ", " ", 150));

            MessageBox.Show($"La Cadena Ordenada Alfabeticamente es: {ordenado = new String(cadena.OrderBy(x => x).ToArray()).ToLower()}");

         }

        public void Cadena2Button_Click(object sender, RoutedEventArgs e)
        {
            string cadena;
            string ordenado;

            cadena = (Microsoft.VisualBasic.Interaction.InputBox($"Digite la Cadena A Ordenar: ", " Cadena Alfabeticamente ", " ", 150));

            MessageBox.Show($"La Cadena Ordenada Alfabeticamente es: {ordenado = new String(cadena.OrderBy(x => x).ToArray()).ToLower()}");

        }
    }
}
