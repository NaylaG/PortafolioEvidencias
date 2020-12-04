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
using LibraryHelados;

namespace Heladeria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ch.Abrir();
            itcHelados.ItemsSource = ch.ListaHelado;

        }
        CatalogoHelados ch = new CatalogoHelados();

        //private void lnkAgregar_Click(object sender, RoutedEventArgs e)
        //{
        //    //try
        //    //{
        //    //    vndAgregarP vndH = new vndAgregarP();
        //    //    Helado h = new Helado();
        //    //    vndH.DataContext = h;
        //    //    if (vndH.ShowDialog() == true)
        //    //    {
        //    //        ch.AgregarHelado(h, vndH.txtRuta.Text);
        //    //    }
            
        //    //}
        //    //catch(Exception m)
        //    //{
        //    //    MessageBox.Show(m.Message);
        //    //}
           
        //}

        //private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    ch.Guardar(); 
        //}

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if((MessageBox.Show("¿Deseas eliminar el producto selecionado?","Producto a eliminar", MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes))
                {
                    var hs = ((FrameworkElement)sender).DataContext as Helado;
                    ch.EliminarHelado(hs);
                    MessageBox.Show("Producto Eliminado");
                }
                

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vndModificarHelado vndM = new vndModificarHelado();
                var hd = ((FrameworkElement)sender).DataContext as Helado;
                vndM.DataContext = hd;
                if(vndM.ShowDialog()==true)
                {
                    var t = ((BitmapImage)vndM.imgProducto.Source).UriSource.LocalPath;
                    ch.ModificarHelado(hd, ((BitmapImage)vndM.imgProducto.Source).UriSource.LocalPath);
                    itcHelados.ItemsSource = null;
                    itcHelados.ItemsSource = ch.ListaHelado;
                }
            }
            catch(Exception m)
            {
              
            }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vndAgregarP vndH = new vndAgregarP();
                Helado h = new Helado();
                vndH.DataContext = h;
                if (vndH.ShowDialog() == true)
                {
                    ch.AgregarHelado(h, vndH.txtRuta.Text);
                }

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            
            ch.Guardar();
            this.Close();
        }

        private void btnMaximizar_Click(object sender, RoutedEventArgs e)
        {
          
            WindowState = WindowState.Maximized;
            btnminimizar.Visibility = Visibility.Visible;
            btnMaximizar.Visibility = Visibility.Hidden;
        }

        //private void btnOculta_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Hide();
        //}

        private void btnminimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            btnminimizar.Visibility = Visibility.Hidden;
            btnMaximizar.Visibility = Visibility.Visible;
        }
    }
}
