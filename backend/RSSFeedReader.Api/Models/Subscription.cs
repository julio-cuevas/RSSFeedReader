namespace RSSFeedReader.Api.Models;

public class Subscription
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FeedUrl { get; set; } = string.Empty;
}
