using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using LibraryHelados;

namespace Heladeria
{
    /// <summary>
    /// Lógica de interacción para vndModificarHelado.xaml
    /// </summary>
    public partial class vndModificarHelado : Window
    {
        public vndModificarHelado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            var t = abrir.FileName;
            if(t==null)
            {
                string tempo = $"{Directory.GetCurrentDirectory()}\\Fotos\\" + $"{((this.DataContext) as Helado).Codigo}.jpg";
                imgProducto.Source = new BitmapImage(new Uri(tempo));
            }
            DialogResult = true;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //Aquí no se si lleva try and catch
            DialogResult = false;
        }
        OpenFileDialog abrir = new OpenFileDialog();
        private void btnAgregaImagen_Click(object sender, RoutedEventArgs e)
        {
            
            abrir.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png";
            MemoryStream archivo = new MemoryStream();
            if (abrir.ShowDialog() == true)
            {
                txtRuta.Text = abrir.FileName;
                imgProducto.Source = new BitmapImage(new Uri(abrir.FileName));
            }
        }
    }
}
