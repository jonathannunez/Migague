using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL TIPO DE GASTO
namespace MiGague.Models
{
    public class TipoGasto
    {
        public static int id { get; set; }
        public string nombre { get; set; }
        public string clasificacion { get; set; }
        public string descripcion { get; set; }
    }
}