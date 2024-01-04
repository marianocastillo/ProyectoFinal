using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace TiendaAPI.Models
{
    public class Articulo{
        [Key]
        public int IdArticulo { get; set; }
        public string? NombreArticulo { get; set; }
        public string? Descripcion { get; set; }
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public required Categorias Categoria { get; set; }

        public int IdSizes { get; set; }
        
        [ForeignKey("Colores")]
        public int IdColores { get; set; }
        public byte[]? imgArt { get; set; }

        
    }
}

