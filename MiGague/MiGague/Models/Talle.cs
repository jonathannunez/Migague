using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL TALLE
namespace MiGague.Models
{
    public class Talle
    {
        public static int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}