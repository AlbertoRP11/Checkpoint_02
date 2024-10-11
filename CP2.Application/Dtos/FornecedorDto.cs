using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class FornecedorDto : IFornecedorDto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public void Validate()
        {
            var validateResult = new FornecedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class FornecedorDtoValidation : AbstractValidator<FornecedorDto>
    {
        public FornecedorDtoValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("O nome é obrigatório.");
            RuleFor(x => x.CNPJ).Length(14).WithMessage("O CNPJ deve ter 14 caracteres.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("O email é inválido.");
            RuleFor(x => x.Telefone).Length(15).WithMessage("O telefone deve ter 15 caracteres.");
        }
    }
}
