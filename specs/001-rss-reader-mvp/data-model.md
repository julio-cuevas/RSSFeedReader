# Data Model: MVP RSS reader

## Entities

### Subscription
- `id`: string or GUID (optional, internal identifier for list items)
- `feedUrl`: string

### SubscriptionList
- `subscriptions`: array of `Subscription`

## Field details
- `feedUrl`: the URL entered by the user as a subscription target
  - Required for the MVP
  - Stored as raw text without URL validation or feed parsing
- `id`: optional internal identifier for list rendering and item tracking
  - If implemented, can be generated on add using a GUID or incremental value

## Relationships
- `SubscriptionList` contains one or more `Subscription` entities
- Each `Subscription` is an element in the list and has no further nested entities for MVP

## Validation rules
- `feedUrl` MUST be non-empty when adding a subscription
- The system MAY ignore entries that are empty or whitespace-only
- Duplicate URLs are allowed in MVP; deduplication is deferred to later phases

## State transitions
- `empty` → `has subscriptions` when the first subscription is added
- `has subscriptions` → `updated` when additional subscriptions are added
- `has subscriptions` → `empty` implicitly when the app reloads or closes (in-memory storage only)
