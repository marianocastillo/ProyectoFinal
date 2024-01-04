using System.ComponentModel.DataAnnotations;

namespace TiendaAPI.Models {

    public class Categorias{
        [Key]
        public int IdCategoria{ get; set; }

        public string? NombreCategoria{ get; set; }
    }
}