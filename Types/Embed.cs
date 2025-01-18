using Newtonsoft.Json;

namespace WebhookLib.Types
{
    public class Embed
    {
        [JsonProperty("author")]
        public EmbedAuthor Author { get; set; }

        [JsonProperty("title")]
        public string Title {  get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public decimal Color { get; set; }

        [JsonProperty("fields")]
        public EmbedField[] Fields { get; set; }

        [JsonProperty("footer")]
        public EmbedFooter Footer { get; set; }
    }
}
