using RegerBiblioteca.Core.ValueObjects;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RegerBiblioteca.API.Converters
{
    public class SenhaJsonConverter : JsonConverter<Senha>
    {
        public override Senha Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var valor = reader.GetString();
            return Senha.Criar(valor); // aqui você usa o método estático
        }

        public override void Write(Utf8JsonWriter writer, Senha value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Valor);
        }
    }

}
