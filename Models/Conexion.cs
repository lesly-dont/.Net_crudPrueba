using Microsoft.EntityFrameworkCore;
namespace api_prueba_web.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Clientes> Clientes {get;set;}     
        public DbSet<Puestos> Puestos {get;set;} 
        public DbSet<Empleados> Empleados {get;set;}      
    }
 class Conectar{
           private const string cadenaConexion = "server=localhost;port=3306;database=db_empresa;userid=root;pwd=leslyquevedo0016";
            public static Conexion Create(){
                var constructor = new DbContextOptionsBuilder<Conexion>();
                constructor.UseMySQL(cadenaConexion);
                var cn = new Conexion (constructor.Options);
                return cn;

            }
        }

}