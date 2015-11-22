using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Event;


namespace Drallo.MultiPlayer.Messages
{
    public class ActivityEventMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivityEvent")]
        public ActivityEvent ActivityEvent;

        public ActivityEventMessage(ActivityEvent activityEvent)
        {
            this.ActivityEvent = activityEvent;
        }
    }
}

