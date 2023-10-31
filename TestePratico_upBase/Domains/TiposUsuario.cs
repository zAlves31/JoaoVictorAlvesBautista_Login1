using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestePratico_upBase.Domains
{
    public class TiposUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "Titulo do tipo usuario obrigatorio!")]
        public string? Titulo { get; set; }
    }
}
