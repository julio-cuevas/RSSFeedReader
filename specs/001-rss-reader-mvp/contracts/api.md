# API Contract: MVP RSS reader

## Purpose
Define the backend API contract for managing subscriptions in the MVP.

## Base URL
`/api/subscriptions`

## Endpoints

### GET /api/subscriptions
Returns the current in-memory list of subscriptions.

#### Response
- Status: `200 OK`
- Body: JSON array of subscription objects

Example:
```json
[
  {
    "id": "1",
    "feedUrl": "https://example.com/feed.xml"
  }
]
```

### POST /api/subscriptions
Adds a new subscription to the in-memory list.

#### Request
- Content-Type: `application/json`
- Body:
```json
{
  "feedUrl": "https://example.com/feed.xml"
}
```

#### Response
- Status: `201 Created`
- Body: the created subscription object

Example:
```json
{
  "id": "2",
  "feedUrl": "https://example.com/feed.xml"
}
```

## Notes
- The MVP does not validate feed URLs or attempt to fetch the feed.
- The API stores subscriptions only in memory for the current application session.
- Duplicate `feedUrl` values are permitted in MVP.
