using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionStore subscriptionStore;

    public SubscriptionsController(SubscriptionStore subscriptionStore)
    {
        this.subscriptionStore = subscriptionStore;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Subscription>> Get()
    {
        return Ok(subscriptionStore.GetAll());
    }

    [HttpPost]
    public ActionResult<Subscription> Post([FromBody] Subscription request)
    {
        if (string.IsNullOrWhiteSpace(request?.FeedUrl))
        {
            return BadRequest(new { error = "feedUrl must not be empty" });
        }

        var subscription = subscriptionStore.Add(request.FeedUrl.Trim());
        return CreatedAtAction(nameof(Get), new { id = subscription.Id }, subscription);
    }
}
