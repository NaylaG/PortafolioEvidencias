using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LibraryHelados
{
    [Serializable]
    public class Helado
    {
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
       
        public ImageSource Image
        {
            get
            {
                string archivo = $"{AppDomain.CurrentDomain.BaseDirectory}/Fotos/{Codigo}.jpg";

                if (!File.Exists(archivo))
                {
                    archivo = $"{AppDomain.CurrentDomain.BaseDirectory}/Fotos/sinfoto.png";
                }

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bi.UriSource = new Uri(archivo);
                bi.EndInit();
                return bi;
            }
        }
    }
}
