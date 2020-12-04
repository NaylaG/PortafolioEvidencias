using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelados
{
    public class CatalogoHelados
    {
        ObservableCollection<Helado> listaHelado;
        public ObservableCollection<Helado> ListaHelado
        {
            get { return listaHelado; }
        }

        public void AgregarHelado(Helado h, string ruta)
        {
            if (String.IsNullOrWhiteSpace(h.Codigo))
                throw new ArgumentException("Escriba el código del producto");
            if (string.IsNullOrWhiteSpace(h.Nombre))
                throw new ArgumentException("Escriba el nombre del producto");
            if (string.IsNullOrWhiteSpace(h.Marca))
                throw new ArgumentException("Escriba la marca del producto");
            if (h.Precio < 1)
                throw new ArgumentException("El precio del helado debe ser mayor a $1.00");
            if (string.IsNullOrWhiteSpace(ruta))
                ruta= $"{AppDomain.CurrentDomain.BaseDirectory}/Fotos/sinfoto.png";
            if (listaHelado == null)
                listaHelado = new ObservableCollection<Helado>();
            listaHelado.Add(h);
            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\Fotos"))
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\Fotos");
            
            File.Copy(ruta, $"{Directory.GetCurrentDirectory()}\\Fotos\\{h.Codigo}.jpg", true);
        }
        public void EliminarHelado(Helado h)
        {
            if (listaHelado.Any(x => x.Codigo == h.Codigo))
            {
                listaHelado.Remove(h);
                File.Delete($"{Directory.GetCurrentDirectory()}\\fotos\\{h.Codigo}.jpg");
            }
        }
        public void ModificarHelado(Helado h, string ruta)
        {
            File.Copy(ruta, $"{Directory.GetCurrentDirectory()}\\Fotos\\{h.Codigo}.jpg", true);
            Guardar();
        }
        
        public void Guardar()
        {
            //serialización
            if (listaHelado != null)
            {
                //Crear el archivo
                FileStream archivo = new FileStream("helados.dat", FileMode.Create);
                BinaryFormatter serializar = new BinaryFormatter();
                serializar.Serialize(archivo, listaHelado);              
                archivo.Close();
            }
        }

        public void Abrir()
        {
            if (File.Exists("helados.dat"))
            {
                FileStream archivo = new FileStream("helados.dat", FileMode.Open);
                BinaryFormatter deserializa = new BinaryFormatter();
                if (listaHelado == null)
                    listaHelado = new ObservableCollection<Helado>();
                listaHelado = (ObservableCollection<Helado>)deserializa.Deserialize(archivo);
                archivo.Close();
            }
        }
    }
}
