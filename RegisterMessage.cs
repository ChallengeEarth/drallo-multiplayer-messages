using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class RegisterMessage : IMessageData
    {
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid MultiPlayerChallengeId;

        public RegisterMessage(string deviceId, Guid multiplayerChallengeId)
        {
            this.DeviceId = deviceId;
            this.MultiPlayerChallengeId = multiplayerChallengeId;
        }
    }
}