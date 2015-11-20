using Newtonsoft.Json;
using System;

namespace dralloMultiPlayer.Messages
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

        public override string ToString()
        {
			return "deviceId: " + deviceId + "; challengeId: " + multiPlayerChallengeID;
        }


    }
}