using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Event;


namespace Drallo.MultiPlayer.Messages
{
    public class ActivityEventMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivityEvent")]
        public ActivityEvent activityEvent;

        public ActivityEventMessage(ActivityEvent activityEvent)
        {
            this.activityEvent = activityEvent;
        }
    }
}

