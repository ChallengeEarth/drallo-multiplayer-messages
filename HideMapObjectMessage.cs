using Newtonsoft.Json;
using System;

namespace Drallo.MultiPlayer.Messages
{
    public class HideMapObjectMessage : IGameManagerMessage
    {
        [JsonProperty]
        public Guid Id;

        public HideMapObjectMessage(Guid id)
        {
            Id = id;
        }
    }
}
