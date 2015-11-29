using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class LocationUpdateMessage : IGameManagerMessage
    {
        [JsonProperty]
        public int PlayerId;

        [JsonProperty]
        public string UserName;

        [JsonProperty]
        public double Longitude;

        [JsonProperty]
        public double Latitude;

        public LocationUpdateMessage(int playerId, string userName, double longitude, double latitude)
        {
            this.PlayerId = playerId;
            this.UserName = userName;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }
    }
}
