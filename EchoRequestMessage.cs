using System;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class EchoRequestMessage : IMessageData
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        [JsonProperty(PropertyName = "timestamp")]
        private DateTime Timestamp;

        public EchoRequestMessage(String message)
        {
            this.Message = message;
            this.Timestamp = DateTime.Now;
        }
    }

}
