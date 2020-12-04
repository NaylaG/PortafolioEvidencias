using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using WPFEmpleados.Views;
using WPFEmpleados.ViewModels;
using WPFEmpleados.Models;
using WPFEmpleados.Repositories;
using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Collections.ObjectModel;

namespace WPFEmpleados.ViewModels
{
    public class EmpleadoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<empleado> ListaEmpleados { get; set; }=
        new ObservableCollection<empleado>();

        public empleado Empleado { get; set; }

        public ICommand AgregarCommand { set; get; }
        public ICommand GuardarCommand { set; get; }
        public ICommand CancelarCommand { set; get; }


        private string error;

        public string Error
        {
            get { return error; }
            set { error = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Error"));
            }
        }

        EmpleadoRepository repos = new EmpleadoRepository();
        Window window;

        //metodos

        private void Cargar()
        {
            ListaEmpleados.Clear();
            foreach(var item in repos.GetEmpleados())
            {
                ListaEmpleados.Add(item);
            }
        }

        private void Agregar()
        {
            Empleado = new empleado();
            window = new RegistroEmpleadosView();
            window.DataContext =this;
            window.ShowDialog();

        }

        private void Cancelar()
        {
            if(window!=null)
            {
                window.Close();
                window = null;
                Error = null;
            }
        }


        public void Guardar()
        {
            Error = null;
            if (repos.Validar(Empleado, out List<string> listaerrores))
            {
                repos.Agregar(Empleado);
                Cancelar();
                Cargar();
            }
            else
                Error = string.Join(Environment.NewLine, listaerrores);
        }


        public EmpleadoViewModel()
        {
            Cargar();
            AgregarCommand = new RelayCommand(Agregar);
            GuardarCommand = new RelayCommand(Guardar);
            CancelarCommand = new RelayCommand(Cancelar);
        }

    }
}
