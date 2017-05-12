using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DEL PROVEEDOR
namespace MiGague.Models
{
    public class Proveedor
    {
        public static int id { get; set; }
        public string codigo { get; set; }
        public string razon_social { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string categoria_tributaria { get; set; }

        //DATOS DE FACTURACION -- pensar si no es una lista
        public string pais { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string direccion_nombre { get; set; }
        public int direccion_numero { get; set; }
        public int direccion_piso { get; set; }
        public string direccion_depto { get; set; }

        //DATOS DE CONTACTO -- pensar si no es una lista
    }
}