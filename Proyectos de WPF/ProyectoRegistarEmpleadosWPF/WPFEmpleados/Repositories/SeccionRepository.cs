using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEmpleados.Models;

namespace WPFEmpleados.Repositories
{
    public class SeccionRepository
    {
        controlempleadosEntities contexto = new controlempleadosEntities();

        public IEnumerable<seccion> GetSecciones()
        {
            return contexto.seccion.OrderBy(x => x.Nombre);
        }
    }
}
