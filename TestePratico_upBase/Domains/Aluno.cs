using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestePratico_upBase.Domains
{
    public class Aluno
    {
        [Key]
        public Guid IdAluno { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Nascimento obrigatorio!")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "Numero de telefone obrigatorio!")]
        public string? Telefone { get; set; }

        [Column(TypeName = "CHAR(7)")]
        [Required(ErrorMessage = "Numero do RG obrigatorio!")]
        public string? RG { get; set; }

        [Column(TypeName = "CHAR(11)")]
        [Required(ErrorMessage = "Numero do CPF obrigatorio!")]
        public string? CPF { get; set; }

        [Column(TypeName = "VARCHAR(1OO)")]
        [Required(ErrorMessage = "Endereco obrigatorio!")]
        public string? Endereco { get; set; }

        //ref.tabela TiposUsuario = FK
        [Required(ErrorMessage = "Informe o usuario ")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
