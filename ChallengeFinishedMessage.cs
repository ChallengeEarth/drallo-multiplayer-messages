using Newtonsoft.Json;
using System.Collections.Generic;

namespace Drallo.MultiPlayer.Messages
{
    public class ChallengeFinishedMessage : IMessageData
    {
        [JsonProperty]
        public Dictionary<string, double> Ranking;

        public ChallengeFinishedMessage(Dictionary<string, double> ranking)
        {
            this.Ranking = ranking;
        }
    }
}
