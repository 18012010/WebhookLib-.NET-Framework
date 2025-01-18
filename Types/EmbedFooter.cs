using Newtonsoft.Json;

namespace WebhookLib.Types
{
    public class EmbedFooter
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
    }
}
