using Microsoft.EntityFrameworkCore;
namespace NETCOREAPI.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Productos> Productos {get;set;}   = null!;  
    }

 class Conectar{
           private const string cadenaConexion = "server=localhost;port=3306;database=db_panaderia;userid=root;pwd=abc123";
            public static Conexion Create(){
                var constructor = new DbContextOptionsBuilder<Conexion>();
                constructor.UseMySQL(cadenaConexion);
                var cn = new Conexion (constructor.Options);
                return cn;

            }
        }

}
