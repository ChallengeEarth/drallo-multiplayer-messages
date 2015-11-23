using Drallo.ChallengeEngine.Feedback;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class TimeLineEntryMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "TimeLineEntry", Required = Required.Always)]
        public TimeLineEntry TimeLineEntry;

        public TimeLineEntryMessage(TimeLineEntry timeLineEntry)
        {
            TimeLineEntry = timeLineEntry;
        }
    }
}
