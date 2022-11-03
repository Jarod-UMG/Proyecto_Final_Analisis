using Microsoft.EntityFrameworkCore;
namespace APICLIENTES.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Clientes> Clientes {get;set;}   = null!;  
    }

 class Conectar{
           private const string cadenaConexion = "server=localhost;port=3306;database=db_clientes;userid=root;pwd=abc123";
            public static Conexion Create(){
                var constructor = new DbContextOptionsBuilder<Conexion>();
                constructor.UseMySQL(cadenaConexion);
                var cn = new Conexion (constructor.Options);
                return cn;

            }
        }

}
