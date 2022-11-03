using System.ComponentModel.DataAnnotations;

namespace APICLIENTES.Models{
    public class Clientes{
        [Key]
        public int id_cliente {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string nit {get; set;}
        public string contraseña {get; set;}
        public string correo {get; set;}
    }
}