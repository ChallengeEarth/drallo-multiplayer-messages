using System;
using Newtonsoft.Json;
using Drallo.ChallengeEngine.Activity.Record;
using Drallo.ChallengeEngine.Activity.Event;


namespace Messages
{
	public class ActivityEventMessage : IGameManagerMessage
	{
		[JsonProperty(PropertyName="ActivityEvent")]
		ActivityEvent activityEvent;

		public ActivityEventMessage ()
		{
		}
	}
}

