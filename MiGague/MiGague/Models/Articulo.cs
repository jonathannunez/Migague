using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL ARTICULO
namespace MiGague.Models
{
    public class Articulo
    {
        public static int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public string talle { get; set; }
        public string temporada { get; set; }
        public string id_sucursal { get; set; }
        public string cantidad { get; set; }
        public double precio_menor { get; set; }
        public double precio_mayor { get; set; }
        public int fallados_definitivos { get; set; }
        public int fallados_fix { get; set; }
        public int perdidas { get; set; }

    }
}