using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonas.Models;
using ProyectoPersonas.Repositories;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;

public enum Sexo { Hombre = 0, Mujer = 1 };
namespace ProyectoPersonas.ViewModels
{
    public class PersonaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Action Cerrar;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo? Genero { get; set; }
        public RelayCommand Agregar { get; set; }
        public RelayCommand Editar { get; set; }
        private string error;
        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Error"));
            }
        }
        //public string TipoGenero
        //{
        //    get {
        //        if (Genero)
        //            return "Hombre";
        //        else
        //            return "Mujer";

        //    }
        //    set { };
        //}
      
        public bool Validar()
        {
            Error = "";
            if (string.IsNullOrEmpty(Nombre))
                Error = "El nombre es obligatorio";
            else if (Edad > 100 || Edad < 0)
                Error = "Edad no válida";
            else if (Genero == null)
            {
                Error = "Seleccione el género";
            }
            return Error == "";
        }

        void AgregarPersona()
        {
            if(Validar())
            {
                PersonasRepository repos = new PersonasRepository();
                Personas p = new Personas
                {
                    Nombre = Nombre,
                    Edad = Edad,
                    Genero = (int)Genero
                };
                repos.Add(p);
                Cerrar?.Invoke();

            }
        }

        public PersonaViewModel()
        {
            Agregar = new RelayCommand(AgregarPersona);
        }

        void EditarPersona()
        {
            if(Validar())
            {
                PersonasRepository repos = new PersonasRepository();
                Personas p = new Personas
                {
                    Edad = this.Edad,
                    Genero = (int)this.Genero,
                    idPersona = this.Id,
                    Nombre = this.Nombre

                };
                repos.Update(p);
                Cerrar?.Invoke();
            }
        }

        public PersonaViewModel(Personas p)
        {
            Id = p.idPersona;
            Nombre = p.Nombre;
            Edad = p.Edad.Value;
            Genero = (Sexo)p.Genero;
            Editar = new RelayCommand(EditarPersona);
        }
    }
}
