using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Record;

namespace Drallo.MultiPlayer.Messages
{
    public class ActivityRecordMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivtyRecord")]
        public ActivityRecord activityRecord;

        public ActivityRecordMessage(ActivityRecord activityRecord)
        {
            this.activityRecord = activityRecord;
        }

    }
}

