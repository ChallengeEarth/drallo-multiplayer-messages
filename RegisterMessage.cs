using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class RegisterMessage : IMessageData
    {
        [JsonProperty(PropertyName = "deviceId")]
        public string deviceId;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid multiPlayerChallengeID;

        public RegisterMessage(string deviceId, Guid multiplayerChallengeId)
        {
            this.deviceId = deviceId;
            this.multiPlayerChallengeID = multiplayerChallengeId;
        }
    }
}