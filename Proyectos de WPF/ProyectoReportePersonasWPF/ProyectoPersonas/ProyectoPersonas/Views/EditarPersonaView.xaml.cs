﻿using System;
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

namespace ProyectoPersonas.Views
{
    /// <summary>
    /// Lógica de interacción para EditarPersonaView.xaml
    /// </summary>
    public partial class EditarPersonaView : Window
    {
        public EditarPersonaView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CmbGenero.ItemsSource = Enum.GetValues(typeof(Sexo));
        }
    }
}
