using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public class SubscriptionStore
{
    private readonly List<Subscription> subscriptions = new();

    public IReadOnlyList<Subscription> GetAll() => subscriptions;

    public Subscription Add(string feedUrl)
    {
        var subscription = new Subscription { FeedUrl = feedUrl };
        subscriptions.Add(subscription);
        return subscription;
    }
}
