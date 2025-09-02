using FluentValidation;
using RegerBiblioteca.Core.Messages.AutorMessages;
using RegerBiblioteca.Core.ViewModels.Autores;

namespace RegerBiblioteca.App.Validators.Autores
{
    public class CreateAutorInputModelValidator : AbstractValidator<CreateAutorInputModel>
    {
        public CreateAutorInputModelValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty()
                    .WithMessage(AutorMsgs.GetNomeNotEmpty())
                .MaximumLength(100)
                    .WithMessage(AutorMsgs.GetNomeMaxLength());

            RuleFor(a => a.Nacionalidade)
                .MaximumLength(100)
                    .WithMessage(AutorMsgs.GetNacionalidadeMaxLength())
                .When(a => !string.IsNullOrEmpty(a.Nacionalidade));

            RuleFor(a => a.DataNascimento)
                .LessThanOrEqualTo(DateTime.Now)
                    .WithMessage(AutorMsgs.GetNascimentoInvalid())
                .When(a => a.DataNascimento.HasValue);

            RuleFor(a => a.FotoUrl)
                .MaximumLength(200)
                    .WithMessage(AutorMsgs.GetFotoUrlMaxLength())
                .When(a => !string.IsNullOrEmpty(a.FotoUrl));

            RuleFor(a => a.SiteUrl)
                .MaximumLength(200)
                    .WithMessage(AutorMsgs.GetSiteUrlMaxLength())
                .When(a => !string.IsNullOrEmpty(a.Nacionalidade));

        }
    }
}
