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
using ProyectoPersonas.ViewModels;

namespace ProyectoPersonas.Views
{
    /// <summary>
    /// Lógica de interacción para ListaPersonasView.xaml
    /// </summary>
    public partial class ListaPersonasView : Window
    {
        ListaPersonasViewModel lp = new ListaPersonasViewModel();
        public ListaPersonasView()
        {
            InitializeComponent();
            lp.Cargar();
            this.DataContext = lp;
            lp.Confirmar = Confirmar;
        }

        public bool Confirmar(string personaEliminar)
        {
            return MessageBox.Show($"Seguro que desea eliminar a " +
           $"{personaEliminar}?", "Atención",
           MessageBoxButton.OKCancel,
           MessageBoxImage.Question) == MessageBoxResult.OK;

        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditarPersonaView ep = new EditarPersonaView();
                Personas p = DtgPersonas.SelectedItem as Personas;
                PersonaViewModel pvm = new PersonaViewModel(p);
                pvm.Cerrar = ep.Close;
                ep.DataContext = pvm;
                ep.ShowDialog();
                lp.Cargar();
            }           
             catch (Exception m)
            {

                MessageBox.Show("Seleccione un paquete", "Atencion");
            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AgregarPersonaView ap = new AgregarPersonaView();
                PersonaViewModel p = new PersonaViewModel();
                p.Cerrar = ap.Close;
                ap.DataContext = p;
                ap.ShowDialog();
                lp.Cargar();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);

            }
        }

        private void BtnImprimir_Click(object sender, RoutedEventArgs e)
        {
            ReportePersonaView rpp = new ReportePersonaView();
            rpp.ShowDialog();
        }
    }
}
