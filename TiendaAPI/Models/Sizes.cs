using System.ComponentModel.DataAnnotations;

namespace TiendaAPI.Models
{
    public class Sizes{
        [Key]
        public int IdSizes{ get; set;}
        public string? SizeName { get; set; }

    }
}