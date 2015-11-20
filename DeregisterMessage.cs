using System;
using dralloMultiPlayer.Messages;
using Newtonsoft.Json;

namespace dralloMultiPlayer.Messages
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