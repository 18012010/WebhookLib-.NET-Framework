using Newtonsoft.Json;

namespace WebhookLib.Types
{
    public class WebhookContent
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("embeds")]
        public Embed[] Embeds { get; set; }
    }
}
