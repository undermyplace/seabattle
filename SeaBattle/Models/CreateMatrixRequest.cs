using System.Text.Json.Serialization;

namespace SeaBattle.Models
{
    public class CreateMatrixRequest
    {
        [JsonPropertyName("range")]
        public int Range { get; set; }
    }
}