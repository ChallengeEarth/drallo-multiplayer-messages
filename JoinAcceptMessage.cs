using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Drallo.MultiPlayer.Messages
{
    public class JoinAcceptMessage : IMessageData
    {
        [JsonProperty(PropertyName = "team")]
        public Team Team;
        [JsonProperty(PropertyName = "multiPlayerChallengeId")]
        public Guid MultiPLayerChallengeId;

        public JoinAcceptMessage(Team team, Guid multiPlayerChallengeId)
        {
            this.MultiPLayerChallengeId = multiPlayerChallengeId;
            this.Team = team;
        }
    }

    public class Team
    {
        [JsonProperty(PropertyName = "name")]
        public string Name;
        [JsonProperty(PropertyName = "players")]
        public List<string> Players;

        public Team(List<string> players)
        {
            this.Players = players;
            this.Name = GetRandomTeamName();
        }

        private string GetRandomTeamName()
        {
            List<string> names = new List<string> { "A-Team", "TeamOne", "WhyDoWeNeedAName?", "IAmNotSureIfWeShouldCreateTeamNamesOnServerSide", "TeamDralloTeamPlay", "EndOfLine" };
            return names[new Random().Next(names.Count - 1)];
        }

    }
}