using System.ComponentModel.DataAnnotations;

namespace NETCOREAPI.Models{
    public class Productos{
        [Key]
        public int id_producto{get; set;}
        public string nombre {get; set;}
        public string foto {get; set;}
        public string descripcion {get; set;}
        public float precio {get; set;}
        public int stock {get; set;}
    }
}