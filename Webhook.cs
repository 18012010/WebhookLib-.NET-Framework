using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebhookLib.Types;

namespace WebhookLib
{
    public class Webhook
    {
        public Webhook(string webhookUrl)
        {
            WebhookUrl = webhookUrl;

            HttpClient = new HttpClient();
        }

        public HttpClient HttpClient { get; internal set; }

        public string WebhookUrl { get; internal set; }

        public async Task<HttpResponseMessage> PostAsync(WebhookContent webhookContent)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(webhookContent));
            stringContent.Headers.Add("content-type", "application/json");

            return await HttpClient.PostAsync(WebhookUrl, stringContent);
        }
    }
}
