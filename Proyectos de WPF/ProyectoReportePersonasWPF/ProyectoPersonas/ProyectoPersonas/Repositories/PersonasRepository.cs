using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonas.Models;

namespace ProyectoPersonas.Repositories
{
    public class PersonasRepository
    {
        RegistroHabitantesEntities1 contexto = new RegistroHabitantesEntities1 ();
        public IEnumerable<Personas> GetAll()
        {
            return contexto.Personas.OrderBy(x => x.Nombre);
        }

        public void Add(Personas p)
        {
            contexto.Personas.Add(p);
            contexto.SaveChanges();
        }

        public void Delete(Personas p)
        {
            var per = contexto.Personas.FirstOrDefault(x => x.idPersona == p.idPersona);
            if(per !=null)
            {
                contexto.Personas.Remove(per);
                contexto.SaveChanges();
            }
        }
        
        public void Update(Personas p)
        {
            var per = contexto.Personas.FirstOrDefault(x => x.idPersona == p.idPersona);
            if(per !=null)
            {
                per.Nombre = p.Nombre;
                per.Genero = p.Genero;
                per.Edad = p.Edad;
                contexto.SaveChanges();

            }
        }

        public Personas GetByID(int id)
        {
            return contexto.Personas.FirstOrDefault(x => x.idPersona == id);
        }
    }
}
