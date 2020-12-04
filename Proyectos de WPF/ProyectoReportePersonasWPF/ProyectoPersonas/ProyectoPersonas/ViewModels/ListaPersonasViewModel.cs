using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonas.Models;
using ProyectoPersonas.Repositories;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ProyectoPersonas.ViewModels
{
    public class ListaPersonasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Personas> Personas { get; set; } = new ObservableCollection<Personas>();
        private int mujeres;
        public int Mujeres
        {
            get { return mujeres; }
            set
            {
                mujeres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mujeres"));
            }
        }

        private int hombres;

        public int Hombres
        {
            get { return hombres; }
            set
            {
                hombres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hombres"));
            }
        }

        public ICommand Eliminar { get; set; }
        public Func<string, bool> Confirmar;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Cargar()
        {
            PersonasRepository datosPersonas = new PersonasRepository();
            Personas.Clear();
            foreach (var item in datosPersonas.GetAll())
            {
                Personas.Add(item);

            }
            Hombres = Personas.Count(x => x.Genero == 0);
            Mujeres = Personas.Count(x => x.Genero == 1);
        }
        public void ELiminarPersona(Personas p)
        {
            if(p!=null)
            {
                if(Confirmar?.Invoke(p.Nombre)==true)
                {
                    PersonasRepository persona = new PersonasRepository();
                    persona.Delete(p);
                    Cargar();
                }
            }
        }
        public ListaPersonasViewModel()
        {
            Eliminar = new RelayCommand<Personas>(ELiminarPersona);
        }
    }
}
