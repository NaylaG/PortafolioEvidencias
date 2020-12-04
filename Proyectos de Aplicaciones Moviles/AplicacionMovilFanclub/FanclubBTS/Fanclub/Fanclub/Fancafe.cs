using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fanclub
{
    public class Fancafe
    {
        public List<Army> listaArmy = new List<Army>();
        public List<Army> LisArmy { get { return listaArmy; } }
        string ruta= Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public void Agregar(Army v)
        {
            if(listaArmy == null)
                listaArmy = new List<Army>();
            if (listaArmy.Any(x => x.Usuario == v.Usuario|| x.Correo ==v.Correo))
                throw new ArgumentException("El usuario ya se encuentra registrado");
            if (string.IsNullOrEmpty(v.Nombre))
                throw new ArgumentException("Favor de ingresar su nombre");
            if (string.IsNullOrEmpty(v.Apellidos))
                throw new ArgumentException("Favor de ingresar sus Apellidos");
            //if (string.IsNullOrEmpty(v.ApellidoM))
            //    throw new ArgumentException("Favor de ingresar su Apellido Materno");
            if (string.IsNullOrEmpty(v.Usuario))
                throw new ArgumentException("Favor de ingresar un nombre de usuario");
            if (string.IsNullOrEmpty(v.Pais))
                throw new ArgumentException("Favor de ingresar su pais de origen");
            if (string.IsNullOrEmpty(v.Correo))
                throw new ArgumentException("Favor de ingresar su correo Electrónico");
            listaArmy.Add(v);
            Guardar();
        }
    
        public void Editar (Army v)
        {
            if (listaArmy != null)
            {
                var temp = listaArmy.FirstOrDefault(x => x.Usuario == v.Usuario);
                temp.Pais = v.Pais;
                temp.Correo = v.Correo;
                Guardar();
            }
        }
        public void Eliminar(Army v)
        {
            if (listaArmy != null)
            {
                if (listaArmy.Any(x => x.Usuario == v.Usuario))
                {
                    listaArmy.Remove(v);
                    Guardar();
                }
                else throw new ArgumentException("No se encuentra ese usuario");
            }
            else throw new ArgumentException("Aun no existen Army registrados");
        }
        public void Guardar()
        {
            if (listaArmy != null)
            {
                FileStream archivo = new FileStream(ruta + "/army.txt", FileMode.Create);
                BinaryFormatter serializa = new BinaryFormatter();
                serializa.Serialize(archivo, listaArmy);
                archivo.Close();
            }
        }

        public void Abrir()
        {
            if (File.Exists(ruta + "/army.txt"))
            {
                FileStream archivo = new FileStream(ruta + "/army.txt", FileMode.Open);
                BinaryFormatter deserializar = new BinaryFormatter();
                if (listaArmy == null)
                    listaArmy = new List<Army>();
                listaArmy = (List<Army>)deserializar.Deserialize(archivo);
                archivo.Close();
            }
        }
    }
}
