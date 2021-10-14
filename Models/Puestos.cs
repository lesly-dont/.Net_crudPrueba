using System;
using System.ComponentModel.DataAnnotations;

namespace api_prueba_web.Models{
    public class Puestos{
        [Key]
        public Int16 id_puesto { get; set;}
        public string puesto { get; set;}
    }
}