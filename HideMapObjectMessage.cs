using Drallo.ChallengeEngine.Feedback.Map;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class HideMapObjectMessage : IGameManagerMessage
    {
        [JsonProperty]
        public IMapObject MapObject;

        public HideMapObjectMessage(IMapObject mapObject)
        {
            MapObject = mapObject;
        }
    }
}
