using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class JoinMessage : IMessageData
    {
        [JsonProperty(PropertyName = "userName")]
        public string Userame;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid MultiPlayerChallengeId;

        public JoinMessage(string username, Guid multiPlayerChallengeId)
        {
            this.Userame = username;
            this.MultiPlayerChallengeId = multiPlayerChallengeId;
        }
    }
}