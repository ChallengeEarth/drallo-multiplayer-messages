using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Event;


namespace Drallo.MultiPlayer.Messages
{
    public class ActivityEventMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivityEvent")]
        public ActivityEvent AcctivityEvent;

        public ActivityEventMessage(ActivityEvent activityEvent)
        {
            this.AcctivityEvent = activityEvent;
        }
    }
}

