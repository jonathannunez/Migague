using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//DEFINICION DE LOS ATRIBUTOS DE LA SUCURSAL
namespace MiGague.Models
{
    public class Sucursal
    {
        public static int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string empresa { get; set; }

        //DATOS DE DIRECCION
        public string pais { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string direccion_nombre { get; set; }
        public int direccion_numero { get; set; }
        public int direccion_piso { get; set; }
        public string direccion_depto { get; set; }
    }
}