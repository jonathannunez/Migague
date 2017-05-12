using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL USUARIO
namespace MiGague.Models
{
    public class Usuario
    {
        public static int id { get; set; }
        public static string nombreUser { get; set; }
        public static string password { get; set; }
        public string nombreEmpleado { get; set; }
        public string rol { get; set; }
        static List<string> lista_funcionalidades;
    }
}