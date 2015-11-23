using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Record;

namespace Drallo.MultiPlayer.Messages
{
    public class ActivityRecordMessage : IGameManagerMessage
    {
        [JsonProperty(PropertyName = "ActivtyRecord", Required = Required.Always)]
        public ActivityRecord ActivityRecord;

        public ActivityRecordMessage(ActivityRecord activityRecord)
        {
            this.ActivityRecord = activityRecord;
        }

    }
}

