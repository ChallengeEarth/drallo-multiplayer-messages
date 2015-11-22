using System;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class EchoReplyMessage : IMessageData
    {
        [JsonProperty(PropertyName = "message")]
        public string message { get; private set; }

        [JsonProperty(PropertyName = "timestamp")]
        private DateTime timestamp;

        public EchoReplyMessage(string message)
        {
            this.message = message;
            this.timestamp = DateTime.Now;
        }
    }

}
