using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Drallo.MultiPlayer.Messages
{
    public class JoinAcceptMessage : IMessageData
    {
        [JsonProperty(PropertyName = "team")]
        public Team team;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid multiPlayerChallengeId;

        public JoinAcceptMessage(Team team, Guid multiPlayerChallengeId)
        {
            this.multiPlayerChallengeId = multiPlayerChallengeId;
            this.team = team;
        }
    }

    public class Team
    {
        [JsonProperty(PropertyName = "name")]
        public string name;
        [JsonProperty(PropertyName = "players")]
        public List<string> players;

        public Team(List<string> players)
        {
            this.players = players;
            this.name = GetRandomTeamName();
        }

        private string GetRandomTeamName()
        {
            List<string> names = new List<string> { "A-Team", "TeamOne", "WhyDoWeNeedAName?", "IAmNotSureIfWeShouldCreateTeamNamesOnServerSide", "TeamDralloTeamPlay", "EndOfLine" };
            return names[new Random().Next(names.Count - 1)];
        }

    }
}