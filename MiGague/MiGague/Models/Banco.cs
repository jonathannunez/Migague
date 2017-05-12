using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL BANCO
namespace MiGague.Models
{
    public class Banco
    {
        public static int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}