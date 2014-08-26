using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public class FloatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(float);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string floatString = reader.ReadAsString();
            float result = float.Parse(floatString.Remove(floatString.Length - 1));
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            float number = (float)value;
            string result = number.ToString("0.0############", CultureInfo.GetCultureInfo("en-US")) + "f";
            writer.WriteRawValue(result);
        }
    }
}
