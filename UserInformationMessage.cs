using Newtonsoft.Json;

namespace dralloMultiPlayer.Messages
{
    public class UserInformationMessage : IMessageData
    {
        [JsonProperty]
        public string information;

        public UserInformationMessage(string information)
        {
            this.information = information;
        }

    }
}
