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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using LibraryHelados;
namespace Heladeria
{
    /// <summary>
    /// Lógica de interacción para vndAgregarP.xaml
    /// </summary>
    public partial class vndAgregarP : Window
    {
        public vndAgregarP()
        {
            InitializeComponent();
        }

        
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {           
       DialogResult = true;                                   
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        private void btnAgregaImagen_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png";
            MemoryStream archivo = new MemoryStream();
            if(abrir.ShowDialog()==true)
            {
                txtRuta.Text = abrir.FileName;
                imgProducto.Source = new BitmapImage(new Uri(abrir.FileName));
            }
          
            
        }
    }
}
