using System;
using System.ComponentModel.DataAnnotations;

namespace api_prueba_web.Models{
public class Empleados{
        [Key]
        public int id_empleado { get; set; }
        public string codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fecha_nacimiento { get; set; }
        public Int16 id_puesto { get; set;}
        
}

}