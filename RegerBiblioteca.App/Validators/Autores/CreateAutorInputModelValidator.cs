using FluentValidation;
using RegerBiblioteca.App.Models.Autores;

namespace RegerBiblioteca.App.Validators.Autores
{
    public class CreateAutorInputModelValidator : AbstractValidator<CreateAutorInputModel>
    {
        public CreateAutorInputModelValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O nome do autor é obrigatório.")
                .MaximumLength(100).WithMessage("O nome do autor deve ter no máximo 100 caracteres.");

            RuleFor(a => a.Nacionalidade)
                .MaximumLength(100).WithMessage("A nacionalidade do autor deve ter no máximo 100 caracteres.")
                .When(a => !string.IsNullOrEmpty(a.Nacionalidade));

            RuleFor(a => a.DataNascimento)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data de nascimento não pode ser no futuro.")
                .When(a => a.DataNascimento.HasValue);

            RuleFor(a => a.FotoUrl)
                .MaximumLength(200).WithMessage("A foto do autor deve ter no máximo 200 caracteres.")
                .When(a => !string.IsNullOrEmpty(a.FotoUrl));

            RuleFor(a => a.SiteUrl)
                .MaximumLength(200).WithMessage("A URL do site do autor deve ter no máximo 200 caracteres.")
                .When(a => !string.IsNullOrEmpty(a.Nacionalidade));

        }
    }
}
