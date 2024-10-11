using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CP2.Domain.Entities
{
    [Table("TB_FORNECEDOR")]
    public class FornecedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
