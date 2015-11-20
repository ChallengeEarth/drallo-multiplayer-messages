using Newtonsoft.Json;
using System;

namespace dralloMultiPlayer.Messages
{
    public class InviteMessage : IMessageData
    {
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid multiPlayerChallengeId;


        public InviteMessage(Guid multiPlayerChallengeId)
        { 
            this.multiPlayerChallengeId = multiPlayerChallengeId;  
        }

        public override string ToString()
        {
            return base.ToString() + "; + multiPlayerChallengeId: " + multiPlayerChallengeId;
        }
    }
}