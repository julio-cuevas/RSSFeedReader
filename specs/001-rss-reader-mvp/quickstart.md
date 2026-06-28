# Quickstart: MVP RSS reader

## Prerequisites
- .NET SDK installed (6.0 or later recommended)
- A terminal or command prompt
- The repository checked out locally

## Setup
1. Open a terminal in the repository root.
2. Ensure the feature directory exists: `specs/001-rss-reader-mvp`
3. Plan document is already generated in `specs/001-rss-reader-mvp/plan.md`.

## Run instructions
Once the MVP implementation is available, validate it with these steps:

1. Start the backend API project:
   - `dotnet run --project backend/RSSFeedReader.Api/RSSFeedReader.Api.csproj`
2. Start the Blazor frontend project:
   - `dotnet run --project frontend/RSSFeedReader.UI/RSSFeedReader.UI.csproj`
3. Open the frontend URL in a browser (typically `http://localhost:5213`).

## Validation scenarios
- Add a feed URL in the subscription input and verify it appears in the subscription list immediately.
- Confirm that the list persists while the app remains open and updates with each new subscription.
- Open the app with no subscriptions and verify the UI shows an empty-state message such as "No subscriptions added yet."
- Confirm that no feed content is fetched or parsed during these actions.

## Expected outcomes
- The application accepts a URL and displays it in the subscription list.
- The UI updates without requiring a manual page refresh.
- The empty state is clearly communicated before any subscriptions are added.
- The MVP remains focused on add/list behavior only.
