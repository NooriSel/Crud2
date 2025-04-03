using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Crud2
{
   public class Cerveza
    {
        public string Nombre {  get; set; }
        public string Estilo { get; set; }
        public double Alcohol { get; set; }
        public Cerveza() {
            this.Nombre = "";
            this.Estilo = "";
            this.Alcohol= 0.0;
        }
        public Cerveza (string Nombre, string Esilo, double Alcohol)
        {
            this.Nombre = Nombre;
            this.Estilo = Esilo;
            this.Alcohol = Alcohol;
        }
    }
}
