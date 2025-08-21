using FluentValidation;
using RegerBiblioteca.Core.ViewModels.Categorias;

namespace RegerBiblioteca.App.Validators.Categorias
{
    public class CreateCategoriaInputModelValidator : AbstractValidator<CreateCategoriaInputModel>
    {
        public CreateCategoriaInputModelValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                    .WithMessage("O nome da categoria é obrigatório.")
                .MaximumLength(200)
                    .WithMessage("O nome da categoria deve ter no máximo 200 caracteres.");

            RuleFor(c => c.Descricao)
                .MaximumLength(500)
                    .WithMessage("A descrição da categoria deve ter no máximo 500 caracteres.")
                .When(c => !string.IsNullOrEmpty(c.Descricao));

            RuleFor(c => c.Genero)
                .IsInEnum()
                    .WithMessage("O gênero da categoria deve ser um valor válido do enum Genero.");
            
            RuleFor(c => c.Ativo)
                .NotNull()
                    .WithMessage("O status ativo da categoria é obrigatório.")
                .Must(status => status == true || status == false)
                    .WithMessage("O status ativo deve ser verdadeiro ou falso.");
        }
    }
}
