using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Mascota
    {
        public int Id { get; set; }
        public String NombreMascota { get; set; }
        public String Raza { get; set; }
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public int PrecioVenta { get; set; }
        public String NombreComprador { get; set; }
        public String RutComprador { get; set; }
    }
}
