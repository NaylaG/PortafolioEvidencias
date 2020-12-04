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
using WPFEmpleados.ViewModels;

namespace WPFEmpleados.Views
{
    /// <summary>
    /// Lógica de interacción para ControlEmpleadosView.xaml
    /// </summary>
    public partial class ControlEmpleadosView : Window
    {
        EmpleadoViewModel em = new EmpleadoViewModel();
        public ControlEmpleadosView()
        {
            InitializeComponent();
            this.DataContext = em;
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
