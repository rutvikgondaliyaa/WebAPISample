using System.Text.Json.Serialization;

namespace Web_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgEnumClass
    {
        Kinght,
        Mage,
        Cleric
    }
}
