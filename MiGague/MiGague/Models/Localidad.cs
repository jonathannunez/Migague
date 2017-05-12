using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DE LA LOCALIDAD
namespace MiGague.Models
{
    public class Localidad
    {
        public static int id { get; set; }
        public int id_pais { get; set; }
        public int id_provincia { get; set; }
        public string nombre { get; set; }
    }
}