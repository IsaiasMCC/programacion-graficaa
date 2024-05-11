using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenTK;

namespace Estructura_Basica_Grafica.helper
{
    public class Matrix4dConverter : JsonConverter<Matrix4d>
    {
      
        public override void Write(Utf8JsonWriter writer, Matrix4d value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    writer.WriteNumberValue(value[i, j]);
                }
            }

            writer.WriteEndArray();
        }
        public override Matrix4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            double[] values = new double[16];

            for (int i = 0; i < 16; i++)
            {
                reader.Read();
                values[i] = reader.GetDouble();
            }

            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return new Matrix4d(
                values[0], values[1], values[2], values[3],
                values[4], values[5], values[6], values[7],
                values[8], values[9], values[10], values[11],
                values[12], values[13], values[14], values[15]);
        }

    }
}
