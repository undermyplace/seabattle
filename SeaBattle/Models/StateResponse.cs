using System.Text.Json.Serialization;
using SeaBattle.Services;

namespace SeaBattle.Models
{
    public class StateResponse
    {

        private readonly BattleInfo _info;

        public StateResponse(BattleInfo info)
        {
            _info = info;
        }


        [JsonPropertyName("ship_count")]
        public int ShipCount => _info.ShipCount;

        [JsonPropertyName("destroyed")]
        public int Destroyed => _info.Destroyed;

        [JsonPropertyName("knocked")]
        public int Knocked => _info.Knocked;

        [JsonPropertyName("shot_count")]
        public int ShotCount => _info.ShotCount;
    }
}