using Newtonsoft.Json;

namespace Drallo.MultiPlayer.Messages
{
    public class UserInformationMessage : IMessageData
    {
        [JsonProperty]
        public string Information;

        public UserInformationMessage(string information)
        {
            this.Information = information;
        }

    }
}
