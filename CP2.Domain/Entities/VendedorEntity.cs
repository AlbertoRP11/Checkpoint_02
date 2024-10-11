using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("TB_VENDEDOR")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; } = string.Empty;

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; } = string.Empty;

        [Required]
        public DateTime DataContratacao { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal ComissaoPercentual { get; set; }

        [Required]
        public decimal MetaMensal { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
