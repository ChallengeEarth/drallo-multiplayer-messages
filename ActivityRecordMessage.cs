using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Record;

namespace Drallo.MultiPlayer.Messages
{
    public class ActivityRecordMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivtyRecord")]
        public ActivityRecord ActivityRecord;

        public ActivityRecordMessage(ActivityRecord activityRecord)
        {
            this.ActivityRecord = activityRecord;
        }

    }
}

