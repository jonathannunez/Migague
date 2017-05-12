using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DE LA PROVINCIA
namespace MiGague.Models
{
    public class Provincia
    {
        public static int id { get; set; }
        public int id_pais { get; set; }
        public string nombre { get; set; }
    }
}