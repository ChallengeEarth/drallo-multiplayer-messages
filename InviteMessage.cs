using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class InviteMessage : IMessageData
    {
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid MultiPlayerChallengeId;

        public InviteMessage(Guid multiPlayerChallengeId)
        { 
            this.MultiPlayerChallengeId = multiPlayerChallengeId;  
        }
    }
}