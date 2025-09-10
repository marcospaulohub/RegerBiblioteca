using FluentValidation;
using RegerBiblioteca.Core.Messages.CategoriaMessages;
using RegerBiblioteca.Core.ViewModels.Categorias;

namespace RegerBiblioteca.App.Validators.Categorias
{
    public class CreateCategoriaInputModelValidator : AbstractValidator<CreateCategoriaInputModel>
    {
        public CreateCategoriaInputModelValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                    .WithMessage(CategoriaMsgs.GetNomeNotEmpty())
                .MaximumLength(200)
                    .WithMessage(CategoriaMsgs.GetNomeMaxLength());

            RuleFor(c => c.Descricao)
                .MaximumLength(500)
                    .WithMessage(CategoriaMsgs.GetDescricaoMaxLength())
                .When(c => !string.IsNullOrEmpty(c.Descricao));

            RuleFor(c => c.Genero)
                .IsInEnum()
                    .WithMessage(CategoriaMsgs.GetGeneroInvalid());
            
            RuleFor(c => c.Ativo)
                .NotNull()
                    .WithMessage(CategoriaMsgs.GetAtivoNotNull())
                .Must(status => status == true || status == false)
                    .WithMessage(CategoriaMsgs.GetAtivoInvalid());
        }
    }
}
