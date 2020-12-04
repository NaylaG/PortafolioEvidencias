using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEmpleados.Models;

namespace WPFEmpleados.Repositories
{
    public class EmpleadoRepository
    {
        controlempleadosEntities contexto = new controlempleadosEntities();

        public IEnumerable<empleado> GetEmpleados()
        {
            contexto = new controlempleadosEntities();
            return contexto.empleado.OrderBy(X => X.Nombre);
        }

        public void Agregar(empleado en)
        {
            contexto.empleado.Add(en);
            contexto.SaveChanges();
        }

        //validaciones
        public bool Validar(empleado en, out List<string> listaerrores)
        {
            listaerrores = new List<string>();
            if (en.Codigo <= 0)
                listaerrores.Add("Escriba el codigo del empleado");
            if (en.IdSeccion <= 0)
                listaerrores.Add("Selecione la seccion del empleado");
            if (string.IsNullOrEmpty(en.Nombre))
                listaerrores.Add("Escriba el Nombre del empleado");
            if (string.IsNullOrEmpty(en.Celular))
                listaerrores.Add("Escriba el Celular del empleado");
            if (string.IsNullOrEmpty(en.Direccion))
                listaerrores.Add("Escriba la Direccion del empleado");
            if (en.Sueldo <= 0)
                listaerrores.Add("El sueldo del empleado debe ser mayor a cero");
            if (contexto.empleado.Any(x => x.Codigo == en.Codigo))
                listaerrores.Add("El empleado ya se encuentra registrado");

            return listaerrores.Count == 0;
        }

    }
}
