using System.Text.Json.Serialization;

namespace SeaBattle.Models
{
    public class ShotResponse
    {
        public ShotResponse(bool knock, bool destroy, bool end)
        {
            Knock = knock;
            Destroy = destroy;
            End = end;
        }


        [JsonPropertyName("destroy")]
        public bool Knock { get; }

        [JsonPropertyName("destroy")]
        public bool Destroy { get; }

        [JsonPropertyName("destroy")]
        public bool End { get; }
    }
}