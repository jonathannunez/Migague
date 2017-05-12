using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL COLOR
namespace MiGague.Models
{
    public class Color
    {
        public static int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}