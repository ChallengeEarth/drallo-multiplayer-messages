using System;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class DeregisterMessage : IMessageData
    {
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid MultiPlayerChallengeId;

        public DeregisterMessage(string deviceId, Guid multiplayerChallengeId)
        {
            this.DeviceId = deviceId;
            this.MultiPlayerChallengeId = multiplayerChallengeId;
        }
    }
}