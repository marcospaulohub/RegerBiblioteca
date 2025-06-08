namespace RegerBiblioteca.Core.ValueObjects
{
    public sealed class Senha : ValueObject
    {
        public const int TamanhoMinimo = 6;
        public const int TamanhoMaximo = 100;

        public string Valor { get; }

        private Senha(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("A senha não pode ser vazia.", nameof(valor));

            if (valor.Length < TamanhoMinimo)
                throw new ArgumentException($"A senha deve ter no mínimo {TamanhoMinimo} caracteres.", nameof(valor));

            if (valor.Length > TamanhoMaximo)
                throw new ArgumentException($"A senha deve ter no máximo {TamanhoMaximo} caracteres.", nameof(valor));

            Valor = valor;
        }

        public static Senha Criar(string valor)
        {
            return new Senha(valor);
        }

        public bool Verificar(string outroValor)
        {
            return Valor == outroValor;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Valor;
        }

        public override string ToString()
        {
            return "****"; // Evita exposição acidental da senha
        }
    }
}
