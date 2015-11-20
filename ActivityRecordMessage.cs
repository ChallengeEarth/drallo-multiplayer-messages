using System;
using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Record;
namespace Messages
{
	public class ActivityRecordMessage : IGameManagerMessage
	{
		[JsonProperty(PropertyName = "ActivityRecord")]
		public ActivityRecord activityRecord;

		public ActivityRecordMessage ()
		{
		}

	}
}

