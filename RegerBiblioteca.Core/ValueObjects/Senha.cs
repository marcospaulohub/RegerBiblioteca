using System.Security.Cryptography;
using System.Text;

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
            var hashOutroValor = ComputeHash(outroValor);

            if(hashOutroValor != Valor)
                return false;

            return true;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Valor;
        }

        public override string ToString()
        {
            return "****"; // Evita exposição acidental da senha
        }

        public static string ComputeHash(string senha)
        {
            using (var hash = SHA256.Create())
            {
                var senhaEmBytes = Encoding.UTF8.GetBytes(senha);

                var hasBytes = hash.ComputeHash(senhaEmBytes);

                var builder = new StringBuilder();

                for (var i = 0; i < hasBytes.Length; i++)
                {
                    builder.Append(hasBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
