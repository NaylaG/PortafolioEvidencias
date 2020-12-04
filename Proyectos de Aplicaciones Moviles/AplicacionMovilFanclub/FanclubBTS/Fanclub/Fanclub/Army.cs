using System;
using System.Collections.Generic;
using System.Text;

namespace Fanclub
{   [Serializable]
    public class Army
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //public string ApellidoM { get; set; }
        public string Usuario { get; set; }
        public string Pais { get; set; }
        public string Correo { get; set; }
    }
}
