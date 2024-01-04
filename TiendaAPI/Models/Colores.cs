using System.ComponentModel.DataAnnotations;

namespace TiendaAPI.Models
{
    public class Colores{
        [Key]
        public int idColores { get; set; }
        public string? NameColores { get; set; }
    


    }
}