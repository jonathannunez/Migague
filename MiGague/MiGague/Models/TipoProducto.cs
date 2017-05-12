using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DE LOS TIPOS DE PRODUCTOS
namespace MiGague.Models
{
    public class TipoProducto
    {
        public static int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set;}
    }
}