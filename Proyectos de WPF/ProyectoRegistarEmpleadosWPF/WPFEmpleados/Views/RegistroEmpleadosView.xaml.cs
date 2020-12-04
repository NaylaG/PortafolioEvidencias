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
    /// Lógica de interacción para RegistroEmpleadosView.xaml
    /// </summary>
    /// s
    public partial class RegistroEmpleadosView : Window
    {
        SeccionViewModel svm = new SeccionViewModel();
        public RegistroEmpleadosView()
        {
            InitializeComponent();
            cmbSeccion.ItemsSource = svm.Secciones;
            cmbSeccion.DisplayMemberPath = "Nombre";
            cmbSeccion.SelectedValuePath = "Id";
        }
    }
}
