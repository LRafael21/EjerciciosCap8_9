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

/*Crear una estructura para guardar los
productos de una tienda.*/


namespace EjerciciosCap8_Cap9.Cap9_Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class Ejercicio1Cap9 : Window
    {
        public string nombreProducto;
        public double Costo;

        public string Descripcion;



        public Ejercicio1Cap9()
        {
            InitializeComponent();

        }

        public struct Productos
        {
            public string nombreProducto;
            public double Costo;
            public string Descripcion;

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"NombreProducto: {nombreProducto}, Costo: {Costo}, Descripcion: {Descripcion}");
                return sb.ToString();
            }
        }

        private void NombreProductoButton_Click(object sender, RoutedEventArgs e)
        {

            nombreProducto = (Microsoft.VisualBasic.Interaction.InputBox($"Digite el nombre del producto: ", " Nombre Del Producto ", " ", 150));

        }

        private void CostoButton_Click(object sender, RoutedEventArgs e)
        {

            Costo = Double.Parse((Microsoft.VisualBasic.Interaction.InputBox($"Digite el Costo del producto: ", " Costo Del Producto ", " ", 150)));

        }


        private void DescripcionButton_Click(object sender, RoutedEventArgs e)
        {

            Descripcion = (Microsoft.VisualBasic.Interaction.InputBox($"Digite la Descripcion del producto: ", " Descripcion Del Producto ", " ", 150));
        }

        private void ImprimirButton_Click(object sender, RoutedEventArgs e)
        {
            
            ListBoxx.Items.Add(nombreProducto.ToString());
            ListBoxx.Items.Add(Costo.ToString());
            ListBoxx.Items.Add(Descripcion.ToString());

        }

       






    }
}
