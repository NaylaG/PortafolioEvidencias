using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEmpleados.Repositories;
using WPFEmpleados.Models;
using WPFEmpleados.ViewModels;
using System.Collections.ObjectModel;

namespace WPFEmpleados.ViewModels
{
    public class SeccionViewModel
    {
        SeccionRepository contexto = new SeccionRepository();
        public ObservableCollection<seccion> Secciones { get; set; } = new ObservableCollection<seccion>();
        public SeccionViewModel()
        {
            foreach(var i in contexto.GetSecciones())
            {
                Secciones.Add(i);
            }
        }

    }
}
