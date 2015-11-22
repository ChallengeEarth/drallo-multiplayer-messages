using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class JoinMessage : IMessageData
    {
        [JsonProperty(PropertyName = "userName")]
        public string userName;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid multiPlayerChallengeId;

        public JoinMessage(string userName, Guid multiPlayerChallengeId)
        {
            this.userName = userName;
            this.multiPlayerChallengeId = multiPlayerChallengeId;
        }
    }
}