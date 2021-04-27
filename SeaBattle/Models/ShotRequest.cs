using System.Text.Json.Serialization;

namespace SeaBattle.Models
{
    public class ShotRequest
    {
        [JsonPropertyName("coords")]
        public string Coordinates { get; set; }
    }
}