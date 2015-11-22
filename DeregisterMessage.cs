using System;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class DeregisterMessage : IMessageData
    {
        [JsonProperty(PropertyName = "deviceId")]
        public string deviceId;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid multiplayerChallengeId;

        public DeregisterMessage(string deviceId, Guid multiplayerChallengeId)
        {
            this.deviceId = deviceId;
            this.multiplayerChallengeId = multiplayerChallengeId;
        }
    }
}