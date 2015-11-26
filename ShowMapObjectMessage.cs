using Drallo.ChallengeEngine.Feedback.Map;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class ShowMapObjectMessage : IGameManagerMessage
    {
        [JsonProperty]
        public IMapObject MapObject;

        public ShowMapObjectMessage(IMapObject mapObject)
        {
            MapObject = mapObject;
        }
    }
}
