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
using ProyectoPersonas.Models;

namespace ProyectoPersonas.Views
{
    /// <summary>
    /// Lógica de interacción para ReportePersonaView.xaml
    /// </summary>
    public partial class ReportePersonaView : Window
    {
        public ReportePersonaView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegistroHabitantesEntities1 contexto = new RegistroHabitantesEntities1();
            rptImpresionPersona.LocalReport.ReportEmbeddedResource = "ProyectoPersonas.rptPersona.rdlc";
            rptImpresionPersona.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPersona", contexto.Personas));
            rptImpresionPersona.RefreshReport();
            //dgvDatos.ItemsSource = contexto.Personas.ToList();
        }
    }
}
