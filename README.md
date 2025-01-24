Requires .NET Framework 4.8.1 and [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) as a dependency.

Example of use:
```csharp
Webhook myWebhook = new Webhook("Webhook URL here");

public void SendWebhook(string message)
{
    var webhookContent = new WebhookContent
    {
        Content = message,
    };

    Task.Run(() => myWebhook.PostAsync(webhookContent));
}
```
