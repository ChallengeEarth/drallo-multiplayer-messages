using System;
using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class EchoReplyMessage : IMessageData
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        [JsonProperty(PropertyName = "timestamp")]
        private DateTime Timestamp;

        public EchoReplyMessage(string message)
        {
            this.Message = message;
            this.Timestamp = DateTime.Now;
        }
    }

}
